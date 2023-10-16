namespace ConversaoCasting
{
    class ConversaoCasting
    {
        public static void Main(string[] args)
        {
            double a; // cabe 8 bytes
            float b; // cabe 4 bytes

            a = 5.1;
            b = (float)a; // Conversão implícita porque é possível caber 4 bytes em 8 bytes;

            Console.WriteLine(b);


            double c; // cabe 8 bytes
            float d; // cabe 4 bytes

            c = 5.1;
            d = (float)c; // se eu quiser que 8 bytes caibam em 4 bytes, vou correr o risco de perder informação. Isso se chama Casting.

            Console.WriteLine(d);
        }
    }
}