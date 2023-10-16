using System.Globalization;

namespace Exec02
{
    class Exec02
    {
        public static void Main(string[] args)
        {
            DadosFuncionario funcionario01 = new DadosFuncionario();
            DadosFuncionario funcionario02 = new DadosFuncionario();

            

            Console.WriteLine("Dadis do primeio funcionário:");
            Console.Write("Nome: ");
            funcionario01.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario01.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            funcionario02.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario02.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario01.Salario + funcionario02.Salario)/ 2.0;

            Console.WriteLine($"Salário médio = {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}