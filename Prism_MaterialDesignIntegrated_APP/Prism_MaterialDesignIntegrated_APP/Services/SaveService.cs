using System;
using System.Collections.Generic;
using System.Text;

namespace Prism_MaterialDesignIntegrated_APP.Services
{
    class SaveService : IOrderService //实现接口
    {
        public void PlaceOrder(List<string> dishes)
        {
            string s = Environment.CurrentDirectory;
            string xmlFileName = System.IO.Path.Combine(s.Substring(0, s.Length - 24), @"Data\DataTxt\TextFile1.txt"); //合成路径
            System.IO.File.WriteAllLines(xmlFileName, dishes.ToArray()); //D盘保存订餐结果
        }
    }
}
