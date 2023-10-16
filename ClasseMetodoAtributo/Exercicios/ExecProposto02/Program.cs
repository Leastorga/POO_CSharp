using System.Globalization;

namespace ExecProposto02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine($"Funcionário: {f1}");
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(porct);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {f1}");
        }
    }
}

