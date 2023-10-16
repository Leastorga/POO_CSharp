namespace Exemplo
{
    class Program
    {
        public static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim(); // Apagar os espaços depois ou antes da string

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("ToTrim: -" + s3 + "-");
        }
    }
}