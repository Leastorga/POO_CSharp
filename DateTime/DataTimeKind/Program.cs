namespace DataTimeKind
{
    class Program
    {
        public static void Main(string[] args)
        {
            // O C# entende que do jeito que instânciei eu quero mostrar
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Unspecified);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1: " + d1.Kind);
            Console.WriteLine("d1: " + d1.ToLocalTime()); // Já está em local
            Console.WriteLine("d1: " + d1.ToUniversalTime()); // Converte para UTF
            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2: " + d2.Kind);
            Console.WriteLine("d2: " + d2.ToLocalTime()); // Converte para Local
            Console.WriteLine("d2: " + d2.ToUniversalTime()); // Já está em UTF
            Console.WriteLine();

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3: " + d3.Kind);
            Console.WriteLine("d3: " + d3.ToLocalTime()); // Converte para Local
            Console.WriteLine("d3: " + d3.ToUniversalTime());// Converte para UTF
            
        }
    }
}