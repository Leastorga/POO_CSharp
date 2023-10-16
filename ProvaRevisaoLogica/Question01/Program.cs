using System;
using System.Globalization;
using System.Xml.Linq;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {

            string[] vet = Console.ReadLine().Split(' ');
            int cod = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double valor = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet[0]);
            int quantidade2 = int.Parse(vet[1]);
            double valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double valorTotal = quantidade * valor + quantidade2 * valor2;
            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
