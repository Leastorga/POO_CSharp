using System;

namespace UsandoUsing
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\97525\Desktop\POO\Arquivos\file01.txt";

            try
            {
                 // Ao utilizarmos o using, assim que terminar de utilizar o arquivo ele será fechado automaticamente. 
                
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);


            }
        }
    }
}