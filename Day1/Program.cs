using Bai1234.DAO;
using Bai1234.Entity;
using OOP_Long.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Bai12342
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductDemo demo = new ProductDemo();
            //demo.Show();
            Database db = new Database();
            db.InitDatabase();
            Console.WriteLine("-----insirt --------");
            Database dbInsirt = new Database();

            dbInsirt.products.Add(new Product(22,22, "Product22"));
            dbInsirt.categories.Add(new Category(22, "Category22"));
            dbInsirt.accessotions.Add(new Accessotion(22, "Accessotion22"));

            dbInsirt.products.Add(new Product(33, 33, "Product33"));
            dbInsirt.categories.Add(new Category(33, "Category33"));
            dbInsirt.accessotions.Add(new Accessotion(3, "Accessotion33"));
            db.InsertTable("product", dbInsirt);
            db.InsertTable("category", dbInsirt);
            db.InsertTable("accessotion", dbInsirt);

            Database update = new Database();
            update.products.Add(new Product(2, 2, "Product2-fix"));
            update.categories.Add(new Category(2, "Category2-fix"));
            update.accessotions.Add(new Accessotion(2, " Accessotion2 -fix"));
            db.UpdateTable("product",update);
            db.UpdateTable("category", update);
            db.UpdateTable("accessotion", update);

            Database dbDelete = new Database();
            dbDelete.products.Add(new Product(3, 3, ""));
            dbDelete.categories.Add(new Category(3, ""));
            dbDelete.accessotions.Add(new Accessotion(3, ""));
            db.DeleteTable("product", dbDelete);
            db.DeleteTable("category", dbDelete);
            db.DeleteTable("accessotion", dbDelete);

            db.PrintTest();
            Console.WriteLine("---------delete pro------------");

            db.TruncateTable("product");
            db.PrintTest();
            Console.WriteLine("---------delete ca------------");

            db.TruncateTable("category");
            db.PrintTest();
            Console.WriteLine("---------delete acc------------");

            db.TruncateTable("accessotion");
            Console.WriteLine("---------delete all------------");

            db.PrintTest();

        }
    }
}
