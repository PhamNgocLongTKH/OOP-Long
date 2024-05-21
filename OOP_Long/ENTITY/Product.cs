using OOP_Long.Pugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Long.ENTITY
{
    internal class Product : Interface_Entity
    {
        protected int ID_Product { get; set; }
        protected int ID_Category { get; set; }
        protected string Name_Product { get; set; }

        public Product(int _idPro, int _idCa, string _name)
        {
            ID_Product = _idPro;
            ID_Category = _idCa;
            Name_Product = _name;
        }
        public Product() { }
        public int GetId()
        {
            return ID_Product;
        }
        public void SetId(int _id)
        {
            ID_Product = _id;
        }
        public string GetName()
        {
            return Name_Product;
        }
        public void SetName(string _name)
        {
            Name_Product = _name;
        }

       
    }
}
