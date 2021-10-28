using Prism.Mvvm;
using Prism_MaterialDesignIntegrated_APP.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prism_MaterialDesignIntegrated_APP.ViewModels
{
    public class UserListItemViewModel : BindableBase
    {
        public User User { get; set; } //数据属性

        private bool isSelected; //私有变量、对应的数据属性，此属性不展示，只作为选中与否的标记
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                this.RaisePropertyChanged("IsSelected");
            }
        }

        public UserListItemViewModel()
        {

        }
    }
}
