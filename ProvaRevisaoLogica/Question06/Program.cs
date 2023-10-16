namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < n; i++)
            {
                int tentativa = int.Parse(Console.ReadLine());

                if (tentativa >= 10 && tentativa <= 20)
                {
                    dentro ++;
                }else
                {
                    fora ++;
                }
            }
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}