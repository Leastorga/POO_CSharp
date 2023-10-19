namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(900000000L);
            TimeSpan t2 = new TimeSpan(2, 11, 21);
            TimeSpan t3 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

            TimeSpan t5 = TimeSpan.FromDays(1.5); // Dá a duração de um dia e meio
            TimeSpan t6 = TimeSpan.FromHours(1.5);
            TimeSpan t7 = TimeSpan.FromMinutes(1.5);
            TimeSpan t8 = TimeSpan.FromSeconds(1.5);
            TimeSpan t9 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t10 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);

        }
    }
}