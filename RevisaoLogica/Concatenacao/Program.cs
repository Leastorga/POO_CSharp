
//Exemplo do uso de Placeholders, concatenação e interpolação

namespace concatenacao
{
    class concatenacao
    {
        public static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            String nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); 
            // Placeholders: dão lugar para uma variável, por isso colocamos depois quais variáveis entram nesses espaços

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            // Interpolação: Adiciona a váriavel apenas usando o $ para mostrar quem entre {} a variável entra.

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
            + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            // Concatenação: Utiliza o sinal de + para adicionar a variável
        }
    }
}

