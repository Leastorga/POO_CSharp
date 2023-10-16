using System.Globalization;

namespace Exec02
{
    class Exec02
    {
        public static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * Math.Pow(raio,2.0);

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");

        }
    }
}