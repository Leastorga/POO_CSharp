using System;

namespace ExemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            // Roda independente se houver exceção ou não
            {
                if (fs != null)
                {
                    fs.Close();
                }

            }
        }
    }
}