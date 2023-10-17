namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(900000000L);
            TimeSpan t2 = new TimeSpan(2, 11, 21);
            TimeSpan t3 = new TimeSpan(1,2,11,21);
            TimeSpan t4 = new TimeSpan(1,2,11,21,321);



            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            
        }
    }
}