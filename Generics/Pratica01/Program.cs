using System;
using Pratica01.Service;

namespace Pratica01 {
    class Program {
        static void Main(string[] args) {

            PrintService<int> printService = new();

            Console.Write("How many values? ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                printService.AddValue(n);
            }
            printService.Print();
            Console.WriteLine();
            Console.WriteLine("First: " + printService.First());
            
            

        }
    }
}