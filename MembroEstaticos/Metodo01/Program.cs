using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static double Pi = 3.14;
        public static void Main(string[] args)
        {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circuferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circuferência: " +  circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " +  vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circuferencia(double r){
            return 2.0 * Pi * r;
        }

        static double Volume(double r){
            return 4.00 / 3.00 * Pi * Math.Pow(r,3);
        }
    }
}