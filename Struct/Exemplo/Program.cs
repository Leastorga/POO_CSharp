namespace Explicacao
{
    class Program
    {
        static void Main(string[]args){

            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

            // mesmo sendo uma Struct é necessário iniciar ela, seja já fornecendo o valor ou criando uma instância
            
        }
    }
}