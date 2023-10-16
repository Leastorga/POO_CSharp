using System.Globalization;

namespace SemPOO
{
    class SemPOO
    {
        public static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do triângulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));
            Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");

            double p2 = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p2 * (p2 - yA) * (p2 - yB) * (p2 - yC));
            Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}