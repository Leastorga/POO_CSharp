namespace DataTimeKind
{
    class Program
    {
        public static void Main(string[] args)
        {
            // O C# entende que do jeito que instânciei eu quero mostrar
            DateTime d01 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d02 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d03 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Unspecified);

            Console.WriteLine("d01: " + d01);
            Console.WriteLine("d01: " + d01.Kind);
            Console.WriteLine("d01: " + d01.ToLocalTime()); // Já está em local
            Console.WriteLine("d01: " + d01.ToUniversalTime()); // Converte para UTF
            Console.WriteLine();

            Console.WriteLine("d02: " + d02);
            Console.WriteLine("d02: " + d02.Kind);
            Console.WriteLine("d02: " + d02.ToLocalTime()); // Converte para Local
            Console.WriteLine("d02: " + d02.ToUniversalTime()); // Já está em UTF
            Console.WriteLine();

            Console.WriteLine("d03: " + d03);
            Console.WriteLine("d03: " + d03.Kind);
            Console.WriteLine("d03: " + d03.ToLocalTime()); // Converte para Local
            Console.WriteLine("d03: " + d03.ToUniversalTime());// Converte para UTF

            DateTime d1 = DateTime.Parse("2000-08-15 13:05:58"); // está unspecified
            DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine();
            
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}