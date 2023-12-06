using System;
using System.Globalization;
using System.Net.Mail;
using Exec01.Entities;

namespace Exec01
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Access> set = new HashSet<Access>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    string name = line[0];
                    DateTime instant = DateTime.Parse(line[1]);
                    set.Add(new Access { Username = name, Instant = instant });
                }
                Console.WriteLine("Total users: " + set.Count);
            }

        }
    }
}