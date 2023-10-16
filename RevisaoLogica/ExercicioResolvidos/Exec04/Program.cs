using System.Globalization;

namespace Exec04
{
    class Exec04
    {
        public static void Main(string[] args)
        {
            int numFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double salario = horasTrabalhadas * valorHora;

            Console.WriteLine($"NUMBER = {numFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}