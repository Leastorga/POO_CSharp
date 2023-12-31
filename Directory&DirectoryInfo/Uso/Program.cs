﻿using System;

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
                // var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                DirectoryInfo folder = new DirectoryInfo(path);
                var folders = folder.EnumerateDirectories("*.*", SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS:");
                foreach (DirectoryInfo item in folders)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("------------------------------------------------------------------------------");

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(path + "\\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);

            }

        }
    }
}