
using System.Globalization;
using ExecFixacao.Entities;
using ExecFixacao.Services;

namespace ExecFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract Data: ");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new(number, date, value);
            ContractService contract = new(new PayPalService());
            contract.ProcessContract(myContract, months);

            Console.WriteLine("INSTALLMENTS: ");
            foreach (Installment item in myContract.Installments)
            {
                Console.WriteLine(item);
            }

        }
    }
}