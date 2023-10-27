using System;
using System.Globalization;
using ExecProposto.Entities;

namespace ExecProposto {
    class Program {
        static void Main(string[] args) {

            List<TaxPayer> list = new();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual ou Company (i/c)? ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(answer == 'i')
                {
                    Console.Write("Health income: ");
                    double healthIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Individual individual = new(name, income, healthIncome);
                    list.Add(individual);
                }else
                {
                    Console.Write("Number of employess: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    Company company = new(name, income, numberOfEmployees);
                    list.Add(company);
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer item in list)
            {
                Console.WriteLine(item.Name + ": $ " + item.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            
            double sum = 0.0;
            foreach (TaxPayer item in list)
            {
                sum += item.Tax();
            }
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}