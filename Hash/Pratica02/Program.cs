using System;

namespace Pratica02
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> ts = new();

            ts.Add("TV");
            ts.Add("Notebook");
            ts.Add("Tablet");

            Console.WriteLine(ts.Contains("Notebook"));
            // Quando utilizamos um conjunto precisamos utilizar foreach
            foreach (string p in ts)
            {
                Console.WriteLine(p);
            }

            //------------------------------------------------//
            SortedSet<int> a = new() { 0, 2, 4, 5, 6, 8, 10 }; // O Sorted sempre ordenará os elementos
            SortedSet<int> b = new() { 5, 6, 7, 8, 9, 10 };

            // Union
            SortedSet<int> c = new(a);
            c.UnionWith(b); // Vou inserir dentro de c, tudo o que estiver em b porém que já não exista em a.
            PrintCollection(c);

            // Intersection
            SortedSet<int> d = new(a);
            d.IntersectWith(b); // Mostra os elementos que existem em comum nos dois conjuntos
            PrintCollection(d);

            // Difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); // Mostra os elementos diferentes entre os conjuntos
            PrintCollection(e);

        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}