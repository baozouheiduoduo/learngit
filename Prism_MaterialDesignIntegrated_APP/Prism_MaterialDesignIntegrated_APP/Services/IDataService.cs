using Prism_MaterialDesignIntegrated_APP.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prism_MaterialDesignIntegrated_APP.Services
{
    interface IDataService//只定义不实现
    {
        List<User> GetAllUser(); //定义方法
        List<Product> GetAllProduct();
    }
}
