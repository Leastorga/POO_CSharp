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

            string s4 = original.Substring(3); // recorta o que estiver antes
            string s5 = original.Substring(3, 5); // recorta o que estiver antes da posição x porém só y caracteres

            string s6 = original.Replace('a', 'x'); //  substituir todo caracter a por x;
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original); // Testa se o conteúdo da variável é nulo ou não
            bool b2 = String.IsNullOrWhiteSpace(original); // Testa se o conteúdo o conteúdo é nulo ou não ou se está em branco.

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("ToTrim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'):" + n1) ;
            Console.WriteLine("LastIndexOf('bc'):" + n2) ;

            Console.WriteLine("Subtring(3): "+ s4);
            Console.WriteLine("Subtring(3, 5): "+ s5);
            Console.WriteLine("Replace(a,x): " + s6);
            Console.WriteLine("Replace(abc, xy): " + s7);

            Console.WriteLine("Is null ou not: " + b1);
            Console.WriteLine("IsNulOrWhiteSpace: " + b2);
        }
    }
}