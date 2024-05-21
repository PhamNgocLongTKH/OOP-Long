using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1234.Entity
{
    internal class Accessotion
    {
        protected int Id_Accessotion { get; set; }
        protected string Name { get; set; }

        public Accessotion(int id_Accessotion, string name)
        {
            Id_Accessotion = id_Accessotion;
            Name = name;
        }

        public int GetID()
        {
            return Id_Accessotion;
        }
        public void SetID(int _id)
        {
            Id_Accessotion = _id;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
