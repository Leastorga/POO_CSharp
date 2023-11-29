using System;
using Exercicio.Entities;
using System.Globalization;
using Exercicio.Services;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number od installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new(number, date, totalValue);
            ContractService service = new(new PaypalService());
            service.ProcessContract(myContract, months);

            Console.WriteLine("INSTALLMENTS: ");
            foreach (Installment item in myContract.Installments)
            {
                Console.WriteLine(item);
            }
            
            
        }

    }
}