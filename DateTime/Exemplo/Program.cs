namespace Exemplo
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2018,11,25); // Especificar a data
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3); // Especificar a data e o horário
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500); // Especificar o milisegundo, porém na hora da impressão a formatação não considera o milisegundo.
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Now;
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today; // Data de hoje sem o horário
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow; // Horário do meridiano de Greenwich
            Console.WriteLine(d6);
        }

    }
}