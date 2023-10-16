using System.Globalization;
using ExecicioDeFixacao01;

namespace ExercicioDeFixacao01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtdd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double cotacao = ConversorDeMoeda.Cotacao(valorDolar, qtdd);
            Console.Write("Valor a ser pago em reais = " + cotacao.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}