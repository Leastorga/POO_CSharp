using System;
using Pratica.Services;

namespace Pratica {
    delegate double BinaryNumericOperation(double n1, double n2); // Determinamos que esse delegate será uma referência a uma função que recebe dois números double e rretorna um número double
    class Program {
        static void Main(string[] args) {

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum; // Instânciamos o delegate de terminando o método que será referenciado
            
            double result = op.Invoke(a,b);

            Console.WriteLine(op);
            

        }
    }
}