using System.Globalization;

namespace Exec05
{
    class Exec05
    {
        public static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet[0]);
            int qttd1 = int.Parse(vet[1]);
            double valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet[0]);
            int qtdd2 = int.Parse(vet[1]);
            double valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double total = qttd1 * valor1 + qtdd2 * valor2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}