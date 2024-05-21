using Bai1234.Entity;
using OOP_Long.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1234.DAO
{
    internal class Database
    {
        public List<Product> products;
        public List<Category> categories;
        public List<Accessotion> accessotions;
        public Database()//ham khoi tao
        {
            categories = new List<Category>();
            products = new List<Product> ();
            accessotions = new List<Accessotion> ();

            
        }
        public void InitDatabase()
        {
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product(i,i,"pro "+i));
                categories.Add(new Category(i,"ca "+i));
                accessotions.Add(new Accessotion(i,"ac "+i));

                
            }
        }

        public int InsertTable(string name, Database db)
        {
            if (name == "product")
            {
                products.AddRange(db.products);
                return 1;
            }
            else if (name == "category")
            {

                categories.AddRange(db.categories);
                return 1;

            }
            else if (name == "accessotion")
            {
                accessotions.AddRange(db.accessotions);
                return 1;

            }
            else
            {
                Console.WriteLine("Nhap lai");
                return 0;

            }
        }
        public int UpdateTable(string name, Database db)
        {
            if (name == "product")
            {
                for (int i = 0; i < products.Count; i++)
                {
                    for (int j = 0; j < db.products.Count; j++)
                    {
                        if (db.products[j].GetID() == products[i].GetID())
                        {
                            products[i] = db.products[j];
                            
                        }

                    }
                }
                return 1;

            }
            else if (name == "category")
            {
                for (int i = 0; i < categories.Count; i++)
                {
                    for (int j = 0; j < db.categories.Count; j++)
                    {
                        if (db.categories[j].GetID() == categories[i].GetID())
                        {
                            categories[i] = db.categories[j];
                        }
                    }
                }

                return 1;

            }
            else if (name == "accessotion")
            {
                for (int i = 0; i < accessotions.Count; i++)
                {
                    for (int j = 0; j < db.accessotions.Count; j++)
                    {
                        if (db.accessotions[j].GetID() == accessotions[i].GetID())
                        {
                            accessotions[i] = db.accessotions[j];
                        }
                    }
                }
                return 1;

            }
            else
            {
                Console.WriteLine("nhap sai");
                return 0;
            }
            return 0;
        }
        public bool DeleteTable(string name, Database db)
        {
            if (name == "product")
            {
                List<Product> listRemove = new List<Product>();
                for (int i = 0; i < products.Count; i++)
                {
                    for (int j = 0; j < db.products.Count; j++)
                    {
                        if (db.products[j].GetID() == products[i].GetID())
                        {
                            listRemove.Add(products[i]);
                        }

                    }
                }
                for (int i = 0; i < listRemove.Count; i++)
                {
                    products.Remove(listRemove[i]);
                }
                return true;


            }
            else if (name == "category")
            {
                List<Category> listRemove = new List<Category>();
                for (int i = 0; i < categories.Count; i++)
                {
                    for (int j = 0; j < db.categories.Count; j++)
                    {
                        if (db.categories[j].GetID() == categories[i].GetID())
                        {
                            listRemove.Add(categories[i]);

                        }
                    }
                }
                for(int i = 0;i< listRemove.Count; i++)
                {
                    categories.Remove(listRemove[i]);
                }

                return true;


            }
            else if (name == "accessotion")
            {
                List<Accessotion> listRemove = new List<Accessotion>();
                for (int i = 0; i < accessotions.Count; i++)
                {
                    for (int j = 0; j < db.accessotions.Count; j++)
                    {

                        if (db.accessotions[j].GetID() == accessotions[i].GetID())
                        {
                            listRemove.Add(accessotions[i]);
                        }
                    }
                }
                for (int i = 0;i < listRemove.Count; i++)
                {
                    accessotions.Remove(listRemove[i]);

                }
                return true;

            }
            else
            {
                Console.WriteLine("nhap sai");
                return false;
            }
            return false;
        }
        public List<object> SelectTable(string name, Func<object, bool> where)
        {
            if (name == "product")
            {  
               return   products.Where(where).ToList();
            }
            else if (name == "category")
            {
                return products.Where(where).ToList();


            }
            else if (name == "accessotion")
            {
               return   products.Where(where).ToList();

            }
            else
            {
                Console.WriteLine("nhap sai");
                return null;
            }
        }
        public void TruncateTable(string name)
        {
            if (name == "product")
            {
                products.Clear();
            }
            else if (name == "category")
            {
                categories.Clear();

            }
            else if (name == "cccessotion")
            {
                accessotions.Clear();

            }
            else
            {
                Console.WriteLine("nhap lai");
            }

        }
        public void PrintTest()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].GetName());
            }
            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine(categories[i].GetName());
            }
            for (int i = 0; i < accessotions.Count; i++)
            {
                Console.WriteLine(accessotions[i].GetName());
            }
        }
    }
}
