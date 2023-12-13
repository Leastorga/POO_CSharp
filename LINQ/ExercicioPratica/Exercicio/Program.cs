using System;
using System.Globalization;
using Exercicio.Entities;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double otherSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employees> list = new();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employees(name, email, salary));
                }
            }

            var names = list.Where(p=> p.Name[0] == 'M').Sum(p=> p.Salary);
            var emails = list.Where(p => p.Salary > otherSalary).OrderBy(p => p.Email).Select(p => p.Email);

            Console.WriteLine("Email of people whose salary is more than " + otherSalary.ToString("F2", CultureInfo.InvariantCulture) +":");
            foreach (string item in emails)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sum of salary of people whose name starts with 'M':" + names.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}