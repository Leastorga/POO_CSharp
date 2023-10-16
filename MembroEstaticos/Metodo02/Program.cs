using System.Globalization;
using metodo02;

namespace MembrosEstaticos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circuferencia(raio);
            double volume = calc.Volume(raio);

            Console.WriteLine("Circuferência: " +  circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " +  volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " +  calc.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}