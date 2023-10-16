namespace Exemplo
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime d2 = new DateTime(2018,11,25); // Especificar a data
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3); // Especificar a data e o horário
            Console.WriteLine(d3);

            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500); // Especificar o milisegundo, porém na hora da impressão a formatação não considera o milisegundo.
            Console.WriteLine(d4);

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
        }

    }
}