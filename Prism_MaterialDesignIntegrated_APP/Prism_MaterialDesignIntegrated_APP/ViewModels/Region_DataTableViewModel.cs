using Prism.Commands;
using Prism.Mvvm;
using Prism_MaterialDesignIntegrated_APP.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prism_MaterialDesignIntegrated_APP.ViewModels
{
    public class Region_DataTableViewModel : BindableBase
    {

        public List<Product> ProductList
        {
            get { return GlobalData.GlobalData.ProductList; }
            set
            {
                value = GlobalData.GlobalData.ProductList;
                this.RaisePropertyChanged();
            }
        }
        public DelegateCommand Refresh { get; set; }
        public void refreshData()
        {
            this.ProductList = GlobalData.GlobalData.ProductList;
        }
        public Region_DataTableViewModel()
        {
            Refresh =new DelegateCommand(refreshData);
        }
    }
}
