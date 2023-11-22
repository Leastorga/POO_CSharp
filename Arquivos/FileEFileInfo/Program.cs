using System;
using System.IO;

namespace FileEFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            string soucePath = @"C:\Users\97525\Desktop\POO\Arquivos\file01.txt"; // Usando o @ para não precisar utilizar C:\\
            string targetPath = @"C:\Users\97525\Desktop\POO\Arquivos\file02.txt";

            try
            {
                // Usando a classe FileInfo
                // CopyTo: Copiar o conteúdo do primeiro arquivo, para algum outro.
                FileInfo fileInfo = new(soucePath);
                fileInfo.CopyTo(targetPath);
            
                // Usando a Classe File    
                // ReadAllLines = Ler o conteúdo do arquivo 
                string[] lines = File.ReadAllLines(soucePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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