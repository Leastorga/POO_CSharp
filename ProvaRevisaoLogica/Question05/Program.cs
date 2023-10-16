namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int senha = 2002;
            int tentativa = int.Parse(Console.ReadLine());

            while (tentativa != senha)
            {
                Console.WriteLine("Senha Invalida");
                tentativa = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}