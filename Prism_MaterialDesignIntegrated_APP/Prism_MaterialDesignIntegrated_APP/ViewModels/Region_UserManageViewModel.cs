using Prism.Commands;
using Prism.Mvvm;
using Prism_MaterialDesignIntegrated_APP.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prism_MaterialDesignIntegrated_APP.ViewModels
{
    public class Region_UserManageViewModel : BindableBase
    {
        public List<User> UserList
        {
            get { return GlobalData.GlobalData.UserList; }
            set
            {
                value = GlobalData.GlobalData.UserList;
                this.RaisePropertyChanged();
            }
        }
        public Region_UserManageViewModel()
        {

        }
    }
}
