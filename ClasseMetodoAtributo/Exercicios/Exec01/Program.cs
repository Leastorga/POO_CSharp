namespace Exec01
{
    class Exec01
    {
        public static void Main(string[] args)
        {

            Dados person01 = new Dados();
            Dados person02 = new Dados();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            person01.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            person01.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            person02.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            person02.Idade = int.Parse(Console.ReadLine());

            if (person01.Idade > person02.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {person01.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {person02.Nome}");
            }
        }
    }
}