using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Long.Class
{
    class Category
    {
        protected int Id_Category;
        protected string Name_Category;

        public Category(int id_Category, string name_Category)
        {
            Id_Category = id_Category;
            Name_Category = name_Category;
        }

        public int GetID()
        {
            return Id_Category;
        }
        public void SetID(int _id)
        {
            Id_Category = _id;
        }
        public string GetName()
        {
            return Name_Category;
        }
    }
}
