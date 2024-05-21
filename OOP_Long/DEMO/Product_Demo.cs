using OOP_Long.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Long.DEMO
{
    internal class Product_Demo : Product
    {
        public Product_Demo()
        {

        }

        public Product_Demo(int _idPro, int _idCa, string _name) : base(_idPro, _idCa, _name)
        {

        }
        public void CreateProductTest()
        {
            Console.WriteLine("ID_Product: ");
            ID_Product = int.Parse(Console.ReadLine());
            Console.WriteLine("ID_Category: ");
            ID_Category = int.Parse(Console.ReadLine());
            Console.WriteLine("Name_Product:  ");
            Name_Product = Console.ReadLine();
        }
        public void printProduct()
        {
            CreateProductTest();
            Console.WriteLine("------------------------------");
            Console.WriteLine("id Id category: " + ID_Product);
            Console.WriteLine("id Id Product: " + ID_Category);
            Console.WriteLine("id name_Product: " + Name_Product);
        }

    }
}
