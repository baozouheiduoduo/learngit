using Prism_MaterialDesignIntegrated_APP.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Prism_MaterialDesignIntegrated_APP.Services
{
    class XmlDataService:IDataService//实现接口 读取xml中所有的菜品信息
    {
        public List<Product> GetAllProduct()
        {
            List<Product> productList = new List<Product>();
            string s = Environment.CurrentDirectory;
            string xmlFileName = System.IO.Path.Combine(s.Substring(0, s.Length - 24), @"Data\DataXml\Products.xml"); //合成路径
            XDocument xDoc = XDocument.Load(xmlFileName); //载入内容
            var products = xDoc.Descendants("Product"); //UserList节点的所有子节点，descendant子代
            foreach (var d in products)
            {
                Product product = new Product();
                product.Type = d.Element("Type").Value;
                product.Code = d.Element("Code").Value;
                product.Quality = d.Element("CodeLevel").Value;
                product.CodeLevel = d.Element("Quality").Value;
                product.Description = d.Element("Description").Value;
                productList.Add(product); //加载到表中
            }
            return productList;
        }

        public List<User> GetAllUser()
        {
            List<User> userList = new List<User>();
            string s = Environment.CurrentDirectory;
            string xmlFileName = System.IO.Path.Combine(s.Substring(0, s.Length - 24), @"Data\DataXml\UserList.xml"); //合成路径
            XDocument xDoc = XDocument.Load(xmlFileName); //载入内容
            var dishes = xDoc.Descendants("User"); //UserList节点的所有子节点，descendant子代
            foreach (var d in dishes)
            {
                User user = new User();
                user.UserName = d.Element("Name").Value;
                user.Password = d.Element("Password").Value;
                user.Access = d.Element("Access").Value;
                userList.Add(user); //加载到表中
            }
            return userList;
        }
    }
}
