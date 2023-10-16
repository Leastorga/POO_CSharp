namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());

            // A vantagem de usar é a segurança e podemos adicionar uma lógica nesses métodos.
            // Também podemos controlar o que pode ser alterado ou não.
        }
    }
}