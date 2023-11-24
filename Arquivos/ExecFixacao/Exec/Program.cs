using Exec.Entities;
using System;
using System.Globalization;
using System.IO;

namespace Exec {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try {

                // Ler o conteúdo do arquivo
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";
                
                Directory.CreateDirectory(targetFolderPath);

                using(StreamWriter stream = File.AppendText(targetFilePath)){
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');

                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new(name, price, quantity);

                        stream.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                    Console.WriteLine("Total feito com sucesso!!!");
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}