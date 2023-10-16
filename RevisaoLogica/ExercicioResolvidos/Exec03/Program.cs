namespace Exec03
{
    class Exec03
    {
        public static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int diferenca = (n1 * n2 - n3 * n4);

            Console.WriteLine($"DIFERENÇA = {diferenca}");
        }
    }
}