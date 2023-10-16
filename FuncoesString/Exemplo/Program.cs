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
            int n1 = original.IndexOf("bc"); // Procurar pela primeira ocorrência do bc
            int n2 = original.LastIndexOf("bc"); // Procurar pela última ocorrência do bc



            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("ToTrim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'):" + n1) ;
            Console.WriteLine("LastIndexOf('bc'):" + n2) ;
        }
    }
}