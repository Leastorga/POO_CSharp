using System;
using System.Globalization;
using ExecResolvido.Entities;

namespace ExecResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char anwser = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value por Hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (anwser == 'y')
                {
                    Console.Write("Additional charge: ");
                    double value2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    OutSourcedEmployee outSourced = new(name, hours, value, value2);
                    list.Add(outSourced);
                }
                else
                {
                    Employee employee = new(name, hours, value);
                    list.Add(employee);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee employee in list)
            {
                Console.WriteLine(employee.Name + " - $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }    
        }
    }
}