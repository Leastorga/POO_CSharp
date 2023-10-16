namespace ExercicioFixacao
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Estudante[] vet = new Estudante[10];
            string name, email;
            int room;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Rent #" + i + ":");

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("E-mail: ");
                email = Console.ReadLine();


                Console.Write("Room: ");
                room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vet[room] = new Estudante(name, email);
            }

            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine($"{i}: {vet[i]}");
                }
            }
        }
    }
}