using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> dictionary = new();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] votingRecord = sr.ReadLine().Split(',');
                    string candidate = votingRecord[0];
                    int votes = int.Parse(votingRecord[1]);
                    
                    if (dictionary.ContainsKey(candidate))
                    {
                        dictionary[candidate] += votes;
                    }
                    else
                    {
                        dictionary[candidate] = votes;
                    }
                }

                foreach (var item in dictionary)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
            }

        }

    }
}