using OOP_Long.ENTITY;
using OOP_Long.Pugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Long.DAO
{
    internal class Database123
    {
        // set key nhap vao
        public Dictionary<string, List<Interface_Entity>> db;

        public Database123()
        {
            // khoi tao doi tuong 
            db = new Dictionary<string, List<Interface_Entity>>();
        }
        public void InsertTable(string _name, Interface_Entity obj)
        {

            if (!db.ContainsKey(_name))//kiem tra neu key khac thi khoi tao danh sach
            {
                db[_name] = new List<Interface_Entity>();
            }
            db[_name].Add(obj);// add vao danh sach
        }

        public List<Interface_Entity> SelectTable(string _name)
        {
            return db[_name];// tra ve name danh sach
        }
        public void UpdateTable(string _name, int _rowID, Interface_Entity obj)
        {
            if (!db.ContainsKey(_name))
            {
                Console.WriteLine("==> Eror!");
            }
            else
            {
                foreach (Interface_Entity entity in db[_name])
                {
                    if (entity.GetId() == _rowID)
                    {
                        int idx = db[_name].IndexOf(entity);
                        db[_name][idx] = obj;
                        return;
                    }
                }
            }

        }
        public void DeleteTable(string _name, int _idRow)
        {
            foreach (string name in db.Keys)
            {
                if (name == _name)
                {
                    foreach (Interface_Entity entity in db[name])
                    {
                        if (entity.GetId() == _idRow)
                        {
                            db[name].Remove(entity);
                            return;
                        }
                    }
                }
            }

        }
        public void TruncateTable()
        {
            foreach (string name in db.Keys)
            {
                db[name].Clear();
            }
        }

    }
}
