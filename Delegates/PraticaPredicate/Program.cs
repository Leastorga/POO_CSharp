using System;
using PraticaPredicate.Entities;

namespace PraticaPredicate
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new();
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD casa", 80.90));
            
            list.RemoveAll(ProductTeste);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTeste(Product p){
            return p.Price >= 100.0;
        }
    }
}