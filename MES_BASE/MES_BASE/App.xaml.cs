using MES_BASE.ViewModels;
using MES_BASE.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace MES_BASE
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

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<Dialog_Login, Dialog_LoginViewModel>();

            containerRegistry.RegisterForNavigation<Region_UserManage>();
        }
    }
}
