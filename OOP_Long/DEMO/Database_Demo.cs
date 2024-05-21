using OOP_Long.DAO;
using OOP_Long.ENTITY;
using OOP_Long.Pugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Long.DEMO
{
    internal class Database_Demo : Database123
    {
        private const string PRODUCT = "product";
        private const string CATEGORY = "category";
        private const string ACCESSOTION = "accessotion";
        public Database_Demo()
        {

        }
        //InsertTableTest
        public void InsertTableTest(string _name, Interface_Entity obj)
        {
            InsertTable(_name, obj);
        }
        //SelectTableTest
        public List<Interface_Entity> SelectTableTest(string _name)
        {
            List<Interface_Entity> interface_Entities = SelectTable(_name);
            for (int i = 0; i < interface_Entities.Count; i++)
            {
                Console.WriteLine("SelectTableTest: " + _name + "_" + i);
            }
            return SelectTable(_name);
        }
        //UpdateTableTest
        public void UpdateTableTest(string name, int _rowID, Interface_Entity obj)
        {
            UpdateTable(name, _rowID, obj);
            SelectTableTest(CATEGORY);
        }
        //DeleteTableTest
        public void DeleteTableTest(string _name, int _idRow)
        {
            DeleteTable(_name, _idRow);
        }
        //TruncateTableTest
        public void TruncateTableTest(string _name)
        {
            TruncateTable();
        }
        //InitDatabaseTest
        public void InitDatabaseTest()
        {
            Console.WriteLine("-----------------------InitDatabaseTest-------------------------");
            for (int i = 0; i < 10; i++)
            {
                InsertTableTest("product", new Product(i, i, "Product_name" + i));
                Console.WriteLine("Category_ID: " + i + "|\t" + "product_ID: " + i + "|\t" + "Name_product_" + i);
            }
            for (int i = 0; i < 10; i++)
            {
                InsertTableTest("category", new Category(i, "category_name " + i));
                Console.WriteLine("Category_ID: " + i + "|\t" + "Category_name" + i);
            }
            for (int i = 0; i < 10; i++)
            {
                InsertTableTest("accessotion", new Accessotion(i, "Accessotion_name " + i));
                Console.WriteLine("accessotion_ID: " + i + "|\t" + "Accessotion_name" + i);
            }
        }
        //PrintTableTest
        public void PrintTableTest()
        {
            //SelectTableTest(PRODUCT);
            //SelectTableTest(CATEGORY);
            SelectTableTest(ACCESSOTION);
        }


    }
}
