using System.Diagnostics;
using System.Globalization;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int cod = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double total;

            switch (cod)
            {
                case 1:
                    total = quantidade * 4.00;
                    break;
                case 2:
                    total = quantidade * 4.50;
                    break;
                case 3:
                    total = quantidade * 5.00;
                    break;
                case 4:
                    total = quantidade * 2.00;
                    break;
                case 5:
                    total = quantidade * 1.50;
                    break;
                default:
                    total = 0.0;
                    break;
            }
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}