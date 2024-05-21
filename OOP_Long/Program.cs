using OOP_Long.DAO;
using OOP_Long.DEMO;
using OOP_Long.ENTITY;
using OOP_Long.Pugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Long
{
    internal class Program
    {
        public const string PRODUCT = "product";
        private const string CATEGORY = "category";
        private const string ACCESSOTION = "accessotion";
        static void Main(string[] args)
        {
            Database_Demo dbTest = new Database_Demo();
            /*bai 1 -->2
            Product_Demo product_Demo = new Product_Demo();
            product_Demo.printProduct();
            */
            // bai 3 --> 7
            dbTest.InitDatabaseTest();

            //SelectTableTest
            Console.WriteLine("----------------------SelectTableTest----------------------------");
            dbTest.SelectTableTest(CATEGORY);
            dbTest.SelectTableTest(PRODUCT);
            dbTest.SelectTableTest(ACCESSOTION);

            //UpdateTableTest
            Console.WriteLine("----------------------UpdateTableTest----------------------------");
            dbTest.UpdateTableTest(CATEGORY, 2, new Category(2, "CATEGORY_new"));

            //UpdateTableTest
            Console.WriteLine("----------------------DeleteTableTest----------------------------");
            dbTest.DeleteTableTest(CATEGORY,2);
            dbTest.SelectTableTest(CATEGORY);

            //TruncateTableTest
            //xoa het cac phan tu trong danh sach
            Console.WriteLine("----------------------TruncateTableTest----------------------------");
            dbTest.TruncateTableTest(CATEGORY);
            dbTest.TruncateTableTest(PRODUCT);
            //dbTest.TruncateTableTest(ACCESSOTION);

            //hien thi bang sau khi xoa het cac phan tu trong DS
            dbTest.SelectTableTest(CATEGORY);
            dbTest.SelectTableTest(PRODUCT);
            dbTest.SelectTableTest(ACCESSOTION);

            Console.WriteLine("----------------------PrintTableTest----------------------------");
            dbTest.PrintTableTest();
        }
    }
}
