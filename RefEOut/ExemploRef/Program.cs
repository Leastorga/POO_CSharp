﻿using Exemplo;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}