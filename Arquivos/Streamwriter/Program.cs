using System;

namespace UsingStreamWriter {
    class Program {
        static void Main(string[] args) {

            // Quero que tudo o que esteja no souce path seja reescrito em maiúsculo e salvo no target path

            string sourcePath = @"C:\Users\97525\Desktop\POO\Arquivos\file01.txt";
            string targetPath = @"C:\Users\97525\Desktop\POO\Arquivos\file02.txt";

            try
            {
                // Criei um vetor chamado lines e utilizei a função read all lines do file e que o que tem que ser lido é o arquivo que está no source path
                string[] lines = File.ReadAllLines(sourcePath);

                // O append text abre o arquivo e escreve o que eu quiser no final dele
                using(StreamWriter sw = File.AppendText(targetPath)){
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);                
            }        
        }
    }
}