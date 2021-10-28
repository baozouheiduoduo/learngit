using Prism.DryIoc;
using Prism.Ioc;
using Prism_MaterialDesignIntegrated_APP.Views;
using System.Windows;

namespace Prism_MaterialDesignIntegrated_APP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App:PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        //复写初始化指令
        protected override void InitializeShell(Window shell)
        {
            //先打开登录窗口，如果登录成功，则打开主窗口
            if (Container.Resolve<LoginWindow>().ShowDialog()==false)
            {
                Application.Current?.Shutdown();
            } 
            else
            {
                base.InitializeShell(shell);
            }           
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Region_Dashboard>();
            containerRegistry.RegisterForNavigation<Region_DataTable>();
            containerRegistry.RegisterForNavigation<Region_UserManage>();
        }
    }
}
