using System;
using ActionPredicate.Entities;

namespace ActionPredicate
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

            // Outras formas de utilizar o action//
            // Action<Product> act = UpdatePrice; Uma possibilidade é instanciar o action
            // Action<Product> act = p => {p.Price += p.Price *0.1; };
            // list.ForEach(p => {p.Price += p.Price *0.1; });

            list.ForEach(UpdatePrice);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}