using MES_BASE.DAL;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MES_BASE.ViewModels
{    
    public class Dialog_LoginViewModel : BindableBase, IDialogAware
    {
        public event Action<IDialogResult> RequestClose;
        private MainWindowViewModel _viewmodel;
        //IRegionManager _regionManager;//定义变量
        //IDialogService _dialogService;
        SqlServrDbase DataDB;
        private string username = "";
        public string UserName
        {
            get { return username; }
            set
            {
                username = value;
                this.RaisePropertyChanged();
            }
        }
        private string password = "";
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                this.RaisePropertyChanged();
            }
        }
        private string info = "";
        public string Info
        {
            get { return info; }
            set
            {
                info = value;
                this.RaisePropertyChanged();
            }
        }
        private DataTable userTable = null;
        public DelegateCommand SaveCommand { set; get; }
        public DelegateCommand CancelCommand { set; get; }
        public string Title => "User Login";

        public Dialog_LoginViewModel()
        {
            SaveCommand = new DelegateCommand(save);
            CancelCommand = new DelegateCommand(cancel);


            //_viewmodel =new MainWindowViewModel(_regionManager, _dialogService);
            _viewmodel = new MainWindowViewModel();

            DataDB = new SqlServrDbase(_viewmodel.ServerName);
            userTable = new DataTable();
        }
        

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            ;
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            //_dialogService = parameters.GetValue<IDialogService>("_dialogService");
            //_regionManager = parameters.GetValue<IRegionManager>("_regionManager");
        }

        private void save()
        {
            try
            {
                if (string.IsNullOrEmpty(UserName.Trim()))
                {
                    Info = "用户名不能为空，请输入正确用户名。";
                    return;
                }
                if (string.IsNullOrEmpty(Password.Trim()))
                {
                    Info = "密码不能为空，请输入正确密码。";
                    return;
                }
                string strsql = "select * from usermanage where 用户名='" + UserName.Trim() + "'";
                userTable = DataDB.GetHistoryOrder(strsql, "MESData");
                int rowNumber = userTable.Rows.Count;
                if (rowNumber > 0)
                {
                    string password = userTable.Rows[0][2].ToString().Trim();
                    if (password == Password.Trim())
                    {
                        int right = Convert.ToInt16(userTable.Rows[0][3]);
                        _viewmodel.userright = right;
                        var parameters = new DialogParameters
                        {
                            { "Result", "Login successfully" }
                        };
                        this.RequestClose(new DialogResult(ButtonResult.OK, parameters));
                    }
                    {
                        Info = "密码错误，请输入正确密码。";
                    }

                }
                else
                {
                    Info = "用户不存在，请登录管理员账户注册新用户。";
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        private void cancel()
        {
            this.RequestClose(new DialogResult(ButtonResult.Cancel));
        }
    }
}
