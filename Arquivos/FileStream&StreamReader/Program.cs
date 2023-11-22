using System;

namespace FileStreamEStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\97525\Desktop\POO\Arquivos\file01.txt";
            StreamReader sr = null;

            try
            {
                
                // fs = new FileStream(path, FileMode.Open); 
                // sr = new StreamReader(fs);
                // # Em vez de instanciarmos assim, há como instanciar o StreamReader sem precisar instanciar o FileStream explicitamente. Para isso, utilizo a classe File para ajudar a instanciar o objeto StreamReader. 
                // Ambas classes é um recurso externo, por conta disso precisamos fechar.

                sr = File.OpenText(path); // Dessa forma, eu instâncio o StreamReader
                while(!sr.EndOfStream) // Enquanto eu não chegar no final do arquivo, vou imprimir seu conteúdo. 
                {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();

            }

        }
    }
}