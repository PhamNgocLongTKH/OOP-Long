using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Long.Class
{
    internal class ProductDemo : Product
    {
        public ProductDemo(int id_Product, int id_Category, string name_Product) : base(id_Product, id_Category, name_Product)
        {

        }
        public ProductDemo() { }
        public void Create()
        {
            Console.WriteLine("Nhap Id Product");
            Id_Product = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Id category");
            Id_Category = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap name_Product ");
            Name_Product = Console.ReadLine();
        }
        public void Show()
        {
            Create();
            Console.WriteLine("id Id category" + Id_Category);
            Console.WriteLine("id Id Product" + Id_Product);
            Console.WriteLine("id name_Product" + Name_Product);
        }
    }
}
