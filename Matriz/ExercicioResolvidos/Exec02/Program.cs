namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine($"Position {i},{j}: ");
                        if (j > 0)
                        {
                            Console.WriteLine($"left: {mat[i, j - 1]}");
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if(i > 0){
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Down: {mat[i + 1,j]}");
                        }
                    }
                }
            }
        }
    }
}