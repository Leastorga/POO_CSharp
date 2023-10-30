using System;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed"); // Message é um atributo no Exception que mostra o erro
            }
            catch(FormatException e){
                Console.WriteLine($"Format error! {e}");
                
            }

        }
    }
}