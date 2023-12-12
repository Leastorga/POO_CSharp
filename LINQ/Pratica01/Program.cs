using System;

namespace Pratica01
{
    class Program
    {
        static void Main(string[] args)
        {

            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define the query
            var result = numbers // Variavel que armazena funções
            .Where(x => x % 2 == 0) // onde x for igual a par 
            .Select(x => x * 10); // selecionar os números e múltiplicar por dez

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}