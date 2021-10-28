using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using Prism_MaterialDesignIntegrated_APP.Model;
using Prism_MaterialDesignIntegrated_APP.Views;
using System;
using System.Windows;

namespace Prism_MaterialDesignIntegrated_APP.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        IRegionManager _regionManager;//定义变量
        IRegionNavigationJournal journal;//导航日志
        IDialogService _dialog;
        #region 委托
        public DelegateCommand CloseWindow { get; set; }
        public DelegateCommand OpenDashboard { get; set; }
        public DelegateCommand OpenDataTable { get; set; }
        public DelegateCommand OpenUserManage { get; set; }
        #endregion

        #region 属性
        private string _title = "Prism Application";
        
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value);RaisePropertyChanged(); }
        }
        public string CurrentUserName 
        {
            get { return GlobalData.GlobalData.CurrentUser.UserName; }
            set 
            {
                value = GlobalData.GlobalData.CurrentUser.UserName;
                this.RaisePropertyChanged(); 
            }
        }
        #endregion

        #region 方法
        public void closeWindow()
        {
            Application.Current.Shutdown();
            //Environment.Exit(0);
        }

        public void openDashboard()
        {
            _regionManager.RequestNavigate("MainContentRegion", "Region_Dashboard", arg =>
            {
                journal = arg.Context.NavigationService.Journal;
            });
        }

        public void  openDataTable()
        {
            _regionManager.RequestNavigate("MainContentRegion", "Region_DataTable", arg =>
            {
                journal = arg.Context.NavigationService.Journal;
            });
        }
        public void openUserMange()
        {
            _regionManager.RequestNavigate("MainContentRegion", "Region_UserManage", arg =>
            {
                journal = arg.Context.NavigationService.Journal;
            });
        }
        #endregion
        public MainWindowViewModel(IRegionManager regionManager, IDialogService dialog)
        {
            //将PrismUserControl用户控件加载到主窗体的ContentRegion中
            regionManager.RegisterViewWithRegion("MainContentRegion", typeof(Region_Dashboard));
            _regionManager = regionManager;
            _dialog = dialog;
            //this.Title = GlobalData.GlobalData.CurrentUser.UserName;


            CloseWindow = new DelegateCommand(closeWindow);
            OpenDashboard = new DelegateCommand(openDashboard);
            OpenDataTable = new DelegateCommand(openDataTable);
            OpenUserManage = new DelegateCommand(openUserMange);
        }
    }
}
