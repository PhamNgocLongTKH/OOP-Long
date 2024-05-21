using OOP_Long.Pugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Long.ENTITY
{
    internal class Accessotion : Interface_Entity
    {
        protected int ID_Accessotion { get; set; }
        protected string Name_Accessotion { get; set; }
        public Accessotion() { }
        public Accessotion(int _idAc, string _nameAc)
        {
            ID_Accessotion = _idAc;
            Name_Accessotion = _nameAc;
        }

        public int GetId()
        {
            return ID_Accessotion;
        }
        public void SetId(int _id)
        {
            ID_Accessotion = _id;
        }
        public string GetName()
        {
            return Name_Accessotion;
        }
        public void SetName(string _name)
        {
            Name_Accessotion = _name;
        }
    }
}
