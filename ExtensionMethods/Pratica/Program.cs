using System;
using Pratica.Extension;

namespace Pratica
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dt = new(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}