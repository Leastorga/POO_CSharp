﻿using SQLLambda.Entities;

namespace SQLLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Print<T>(string message, IEnumerable<T> collection)
            {
                Console.WriteLine(message);
                foreach (T obj in collection)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }

            Category c1 = new() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new(){
                new Product(){Id = 1, Name= "Computer", Price = 1100.0, Category = c2},
                new Product(){Id = 2, Name= "Hammer", Price = 90.0, Category = c1},
                new Product(){Id = 3, Name= "TV", Price = 1700.0, Category = c3},
                new Product(){Id = 4, Name= "Notebook", Price = 1300.0, Category = c2},
                new Product(){Id = 5, Name= "Saw", Price = 80.0, Category = c1},
                new Product(){Id = 6, Name= "Talet", Price = 700.0, Category = c2},
                new Product(){Id = 7, Name= "Camera", Price = 700.0, Category = c3},
                new Product(){Id = 8, Name= "Printer", Price = 350.0, Category = c3},
                new Product(){Id = 9, Name= "MacBook", Price = 1800.0, Category = c2},
                new Product(){Id = 10, Name= "Sound Bar", Price = 700.0, Category = c3},
                new Product(){Id = 11, Name= "Level", Price = 70.0, Category = c1}
            };
            var r1 =
            from p in products
            where p.Category.Tier == 1 && p.Price < 900.0
            select p;
            Print("TIER 1 AND PRICE > 900: ", r1);

            var r2 =
            from p in products
            where p.Category.Name == "Tools"
            select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS: ", r2);

            var r3 =
            from p in products
            where p.Name[0] == 'C'
            // Objeto anônimo é utilizado quando eu não quero criar uma classe para armazenar esses atributos.
            select new
            {
                p.Name,
                p.Price,
                CategoryName = p.Category.Name
            };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT: ", r3);

            var r4 =
            from p in products
            where p.Category.Tier == 1
            orderby p.Name
            orderby p.Price
            select p;
            Print("TIER 1 ORDER BY PRICE THEN BY NAME: ", r4);

            var r5 =
            (from p in r4
            select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4: ", r5);


            var r6 =
            from p in products
            group p by p.Category;
            foreach (IGrouping<Category, Product> group in r6)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}