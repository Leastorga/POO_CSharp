using System;
using PraticaFun.Entities;

namespace PraticaFun {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD case", 80.90));

            // Func<Product,string>func = NameUpper;
            // List<string> result = list.Select(func).ToList();
           
           // *Expressão Lambda*//
            // Func<Product,string>func = p => p.Name.ToUpper();
            // List<string> result = list.Select(func).ToList();

           // *Expressão Lambda inline*//
            // List<string> result = list.Select(= p => p.Name.ToUpper()).ToList();


            List<string> result = list.Select(NameUpper).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
        static string NameUpper(Product p ){
            return p.Name.ToUpper();
        }
    }
}