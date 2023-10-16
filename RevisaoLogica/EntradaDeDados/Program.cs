namespace EntradaDeDados
{
    class EntradaDeDados
    {
        public static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            string d = Console.ReadLine();
            

            string[] vet = Console.ReadLine().Split(' ');
            string c1 = vet[0];
            string c2 = vet[1];
            string c3 = vet[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}