using System;

namespace UsandoDirectoryEDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\97525\Desktop\POO\Directory&DirectoryInfo\myfolder";

            try
            {
                // *.* qualquer nome de arquivo e 
                // SearchOption.AllDirectories = Procurar todas as opções em todos os diretórios
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string item in folders)
                {
                    Console.WriteLine(item);
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