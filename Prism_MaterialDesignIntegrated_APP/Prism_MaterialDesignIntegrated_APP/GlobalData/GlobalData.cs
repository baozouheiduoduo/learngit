using Prism.Mvvm;
using Prism_MaterialDesignIntegrated_APP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Prism_MaterialDesignIntegrated_APP.GlobalData
{
    public static class GlobalData
    {
        public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;
        public static List<User> UserList { get; set; }
        public static List<Product> ProductList { get; set; }
        //private static User currentUser = new User() { UserName = "", Password = "", Access = "" };
        //public static User CurrentUser
        //{
        //    get
        //    {
        //        return currentUser;
        //    }
        //    set
        //    {
        //        value = currentUser;

        //        //调用通知
        //        //StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(CurrentUser)));
        //    }
        //}
        public static User CurrentUser { get; set; }
    }
}
