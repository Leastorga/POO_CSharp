﻿namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            // GetValueOrDefault = Pega o valor da variável escolhida ou então seu valor Padrão caso seja nulo

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            // Hasvalue = diz se tem ou não valor armazenado (true or false)

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
                // Value = é o valor de x, caso seja nulo o programa quebra.
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
                // Value = é o valor de y, caso seja nulo o programa quebra.
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            // Operador de coalescência nula

            double? a = null;
            double? b = 10;

            double c = a ?? 5;
            double d = b ?? 5;

            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}