using System.Globalization;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double delta = Math.Pow(b, 2) - 4 * a * c;
            double x1 = 0.00;
            double x2 = 0.00;

            if (a == 0)
            {
                Console.WriteLine("Impossível calcular");
            }else if(delta < 0){
                Console.WriteLine("Impossível calcular");
            }else{
                x1 = (double)(-b + Math.Sqrt(delta))/ (2.0 * a);
                x2 = (double)(-b - Math.Sqrt(delta)) / (2.0 * a);
                Console.WriteLine("x1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("x2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}