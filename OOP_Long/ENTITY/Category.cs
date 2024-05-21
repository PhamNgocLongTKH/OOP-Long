using OOP_Long.Pugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Long.ENTITY
{
    internal class Category: Interface_Entity
    {
        protected int ID_Category { get; set; }
        protected string Name_Category { get; set; }

        public Category() { }
        public Category(int _idCa, string _nameCa)
        {
            ID_Category = _idCa;
            Name_Category = _nameCa;
        }
        public int GetId()
        {
            return ID_Category;
        }
        public void SetID( int _id)
        {
            ID_Category = _id;
        }
        public string GetName()
        {
            return Name_Category;
        }
        public void SetName(string _name)
        {
            Name_Category = _name;
        }

        
    }
}
