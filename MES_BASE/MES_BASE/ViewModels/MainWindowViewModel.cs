using MES_BASE.Common;
using MES_BASE.DAL;
using MES_BASE.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Xml.Serialization;
using Umbraco.ModelsBuilder.Building;

namespace MES_BASE.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public int userright = -1;
        public string ServerName = "";//服务器名字
        DispatcherTimer Timerload;
        IRegionManager _regionManager;//定义变量
        IRegionNavigationJournal journal;//导航日志
        IDialogService _dialogService;
        private SystemSet ps = new SystemSet();
        SqlServrDbase SqlData;//定义数据库连接
        #region 字段和属性
        //private TypeModel selectItem;
        //public TypeModel SelectItem
        //{
        //    get { return selectItem; }
        //    set { SetProperty(ref selectItem, value); }
        //}
        #endregion
        #region 声明命令
        public DelegateCommand<string> ChangeLanguage { get; set; }
        public DelegateCommand<object> MenuTreeChanged { get; set; }
        #endregion
        #region 定义方法
        private void changeLanguage(object para)
        {
            ResourceDictionary langRd = null;
            langRd = Application.LoadComponent(new Uri(@"language\" + para + ".xaml", UriKind.Relative)) as ResourceDictionary;            
            if (langRd != null)
            {
                //如果已使用其他语言,先清空

                if (Application.Current.Resources.MergedDictionaries.Count > 5)
                {
                    Application.Current.Resources.MergedDictionaries.RemoveAt(4);
                }
                Application.Current.Resources.MergedDictionaries.Add(langRd);

            }
        }
        private void Timerload_Tick(object sender,EventArgs e)
        {
            Timerload.Stop();
            ReadSystemSet();//读取系统信息            
            DataIntial();//数据库初始化
            userRightControl();//用户权限显示菜单栏
        }
        private void ReadSystemSet()
        {
            try
            {
                ReadPortXml();
                ServerName = ps.SQLName;//数据库名称
                SqlData = new SqlServrDbase(ServerName);

                //digScreenX = int.Parse(ps.BigX.Trim());
                //digScreenY = int.Parse(ps.BigY.Trim());
                //QualityScreenX = int.Parse(ps.QualityX.Trim());
                //QualityScreenY = int.Parse(ps.QualityY.Trim());
            }
            catch (Exception ex)
            {
                //MessageBox.Show("读取系统信息时出错，" + ex.Message);
            }
        }
        private void ReadPortXml()
        {
            //string path = Application.StartupPath + @"\SystemSet.xml";
            string path = Directory.GetCurrentDirectory()+ @"\SystemSet.xml";
            StreamReader sr = new StreamReader(path);
            XmlSerializer xs = new XmlSerializer(typeof(SystemSet));
            ps = (SystemSet)xs.Deserialize(sr);
            sr.Close();
        }
        private void DataIntial()
        {
            try
            {
                //创建数据库
                string ptch = @"D:\data\";
                SqlData.CreateDataBase("MESData", ptch);
                //创建用户数据表
                Dictionary<string, string> dicUser = new Dictionary<string, string>();
                dicUser.Add("ID int", "IDENTITY (1,1) not null");
                dicUser.Add("用户名 char(20)", "null");
                dicUser.Add("密码 char(20)", "null");
                dicUser.Add("权限 int", "null");
                SqlData.CreateDataTable("MESData", "usermanage", dicUser);
            }
            catch (Exception ex)
            {

            }
        }
        void userRightControl()
        {
            switch(userright)
            {
                case -1://无任何权限
                    break;
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
                   

            }
        }
        public void regionChange(object obj)
        {
            var node = (obj as TreeViewItem).Tag;
            if(node != null)
            {
                //用户登录
                if (node.ToString() == "UserLogin")
                {
                    DialogParameters param = new DialogParameters();
                    //param.Add("_dialogService", _dialogService);
                    //param.Add("_regionManager", _regionManager);
                    _dialogService.ShowDialog("Dialog_Login", param, arg => { });
                    //_dialogService.ShowDialog("Dialog_Login");
                }
                if(node.ToString() == "UserManage")
                {
                    _regionManager.RequestNavigate("ContentRegion", "Region_UserManage", arg =>
                    {
                        journal = arg.Context.NavigationService.Journal;
                    });
                }
            }           
        }
        #endregion
        public MainWindowViewModel(IRegionManager regionManager, IDialogService dialog)
        {  
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Region_UserManage));
            this._regionManager = regionManager;
            this._dialogService = dialog;
            ChangeLanguage = new DelegateCommand<string>(changeLanguage);
            MenuTreeChanged = new DelegateCommand<object>(regionChange);
            userright = -1;
            Timerload = new DispatcherTimer();
            Timerload.Interval = TimeSpan.FromMilliseconds(1000);
            Timerload.Tick += new EventHandler(Timerload_Tick);
            Timerload.Start();
        }
        public MainWindowViewModel()
        {

        }
    }
}
