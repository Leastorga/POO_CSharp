using System.Globalization;

namespace Exemplo
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018,11,25); // Especificar a data
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3); // Especificar a data e o horário
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500); // Especificar o milisegundo, porém na hora da impressão a formatação não considera o milisegundo.
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Now;
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today; // Data de hoje sem o horário
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow; // Horário do meridiano de Greenwich
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-15"); // Converter a data para esse formato ( tentará interpretar a data em vários formatos)
            Console.WriteLine(d7);

            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine(d8);

            DateTime d9 = DateTime.Parse("15/08/2000");  // Converter a data para esse formato
            Console.WriteLine(d9);

            DateTime dt  = DateTime.ParseExact("2000-08-15","yyyy-MM-dd", CultureInfo.InvariantCulture); // Especifico o formato exato em que a data estarão representadas na entrada
            Console.WriteLine(dt);
            
        }

    }
}