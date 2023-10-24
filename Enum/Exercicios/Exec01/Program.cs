using System;
using System.Globalization;
using Exec01.Entities;
using Exec01.Entities.Enums;

namespace Exec01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dpt = new Department(department);
            Worker worker = new Worker(name, level, baseSalary, dpt);

            Console.Write("How many contractys to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours); // Criei um contrato
                worker.AddContracts(contract); // Adicionei esse contrato a minha lista de contratos
            }

            Console.Write("Entre month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Department: {worker.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}