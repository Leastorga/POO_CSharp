using System;
using Pratica01.Entities;

namespace Pratica01 {
    class Program {
        static void Main(string[] args) {

            Client a = new(){Name = "Maria", Email = "maria@gmail.com"};
            Client b = new(){Name = "Alex", Email = "Alex@gmail.com"};
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}