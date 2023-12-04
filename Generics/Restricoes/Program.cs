using System;
using System.Globalization;
using Restricoes.Entities;
using Restricoes.Services;

namespace Restricoes {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new ();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new();
            Product max = calculationService.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);

        }
    }
}