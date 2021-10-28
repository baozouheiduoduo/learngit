
using Prism.Commands;
using Prism.Mvvm;
using Prism_MaterialDesignIntegrated_APP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Prism_MaterialDesignIntegrated_APP.ViewModels
{
    public class LoginWindowViewModel : BindableBase
    {
        //private List<UserListItemViewModel> userList; //私有变量、对应的数据属性2
        //public List<UserListItemViewModel> UserList //DishMenuItemViewModel类组成的集合
        //{
        //    get { return userList; }
        //    set
        //    {
        //        userList = value;
        //        this.RaisePropertyChanged("UserList");
        //    }
        //}
        public LoginWindowViewModel()
        {
            LoginCommand = new DelegateCommand<object>(login);
            CloseLoginWindow = new DelegateCommand<object>(closeLoginWindow);

            IDataService ds = new XmlDataService();
            GlobalData.GlobalData.UserList = ds.GetAllUser(); //得到用户所有的列表

            GlobalData.GlobalData.ProductList = ds.GetAllProduct();
            //this.UserList = new List<UserListItemViewModel>();
            //foreach (var user in UserList)
            //{
            //    UserListItemViewModel item = new UserListItemViewModel();
            //    item.User = user.User;
            //    this.UserList.Add(item);
            //}
        }

        private string _username = "Admin";
        public string UserName
        {
            get { return _username; }
            set { _username = value; RaisePropertyChanged(); }
        }
        private string _password = "Admin";
        public string Password
        {
            get { return _password; }
            set { _password = value; RaisePropertyChanged(); }
        }
        private string _errorMsg;
        public string ErrorMsg
        {
            get { return _errorMsg; }
            set { _errorMsg = value; RaisePropertyChanged(); }
        }

        //登录命令
        public DelegateCommand<object> LoginCommand { get; set; }
        public DelegateCommand<object> CloseLoginWindow { get; set; }

        private void login(object obj)
        {
            try
            {
                this.ErrorMsg = "";
                if (string.IsNullOrEmpty(this.UserName))
                {
                    throw new Exception("请输入用户名！");
                }
                if (string.IsNullOrEmpty(this.Password))
                {
                    throw new Exception("请输入密码！");
                }
                //简化后登录逻辑
                var tempList = GlobalData.GlobalData.UserList.Where(i => i.UserName == UserName).ToList();
                if (tempList.Count==1)
                {                  
                    if(tempList.Where(i=>i.UserName == this.UserName && i.Password == this.Password).ToList().Count>0)
                    {
                        foreach (var item in tempList)
                        {
                            if (item.UserName == this.UserName && item.Password == this.Password)
                            {
                                GlobalData.GlobalData.CurrentUser = item;                              
                                (obj as Window).DialogResult = true;                                
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("密码错误！");
                    }
                }
                else
                {
                    throw new Exception("用户名不存在！");
                }


                //登录逻辑
                //if (_loginBLL.Login(this.UserName,this.Password).GetAwaiter().GetResult())
                //{
                //    //关闭登录窗口，并且返回DialogResult TRUE
                //    (obj as Window).DialogResult = true;
                //}
                //else
                //{
                //    this.ErrorMsg = "登录失败！用户名或密码错误";
                //}

                //关闭登录窗口，并且返回DialogResult TRUE
                //    (obj as Window).DialogResult = true;
            }
            catch (Exception ex)
            {
                this.ErrorMsg = "登录失败:" + ex.Message;
            }
        }
        public void closeLoginWindow(object obj)
        {
            (obj as Window).DialogResult = false;
        }
    }
}
