using System;
using Exec.Entities;

namespace InterfaceComparable {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\97525\Desktop\POO\Interface\IntrerfaceComparable\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee> ();
                    while(!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();  // Para esse função funcionar preciso utilizar a Interface Comparable
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}