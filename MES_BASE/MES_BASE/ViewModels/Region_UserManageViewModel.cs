using MES_BASE.DAL;
using MES_BASE.Entity;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Documents;

namespace MES_BASE.ViewModels
{
    public class Region_UserManageViewModel : BindableBase
    {
        private MainWindowViewModel _viewmodel;       
        SqlServrDbase DataDB;
        private List<User> userlist;
        public List<User> UserList
        {
            get
            {
                return userlist;
            }
            set
            {
                userlist = value;
                this.RaisePropertyChanged();
            }
        }


        public Region_UserManageViewModel()
        {
            try
            {
                _viewmodel = new MainWindowViewModel();
                DataDB = new SqlServrDbase(_viewmodel.ServerName);
                string strsql = "select * from usermanage";
                DataTable selectTable = DataDB.GetHistoryOrder(strsql, "MESData");
                int Rownumber = selectTable.Rows.Count;
                if (Rownumber > 0)
                {
                    UserList = (from DataRow dr in selectTable.Rows
                            select new User
                            {
                                UserName = dr["用户名"].ToString(),
                                Password = dr["密码"].ToString(),
                                Access = dr["权限"].ToString()                              
                            }).ToList();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("读取用户名错误，" + ex.Message);

            }
        }
    }
}
