using System.Globalization;

namespace ExecProposto01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"AREA = {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"AREA = {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}