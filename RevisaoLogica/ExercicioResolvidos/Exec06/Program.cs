using System.Globalization;

namespace Exec06
{
    class Exec06
    {
        public static void Main(string[] args)
        {   
            double pi = 3.14159;
            string[] vet = Console.ReadLine().Split(' ');
            double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double trianguloRetangulo = (n1 * n3) / 2.0;
            double circulo = pi * Math.Pow(n3, 2.0);
            double trapezio = ((n1 + n2 ) * n3) / 2.0;
            double quadrado = Math.Pow(n2, 2);
            double retangulo = n1 * n2;

            Console.WriteLine($"TRIANGULO: {trianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}