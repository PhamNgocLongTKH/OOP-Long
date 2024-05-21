using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Long.Class
{
    internal class Product
    {
        protected int Id_Product ;
        protected int Id_Category;
        protected string Name_Product;

        public Product(int id_Product, int id_Category, string name_Product)
        {
            Id_Product = id_Product;
            Id_Category = id_Category;
            Name_Product = name_Product;
        }
        public Product() { }
        public int GetID()
        {
            return Id_Product;
        }
        public void SetID(int _id)
        {
            Id_Product = _id;
        }
        public string GetName()
        {
            return Name_Product;
        }
    }
}
