namespace Pratica
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>
            {
                "Maria",
                "Alex",
                "Bob",
                "Anna"
            }; // list.add - adiciona o elemento que eu quiser

            list.Insert(2, "Marco"); // adiciona na posição e o que eu quiser.

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count); // Mostra o tamanho da lista

            string s1 = list.Find(x => x[0] == 'A'); // Encontre o x que na posição 0 (primeira letra) seja igual a A (Expressão Lambda)
            Console.WriteLine("First 'A': " + s1); // a função Find recebe como argumento outra função que faz um teste em cima daquilo que procuramos

            string s2 = list.FindLast(x => x[0] == 'A'); // A função FindLast procura o ultimo elemento da lista que satisfaça a lógica do predicado. 
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); // A função FindIndex procura a posição do primeiro elemento da lista que satisfaça a lógica do predicado.
            Console.WriteLine("Firt position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // A função FindLastIndex procura a posição do ultimo elemento da lista que satisfaça a lógica do predicado.
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5); // O FindAll filtra aquilo que satisfaça o predicado, colocando o resultado em uma nova lista
            Console.WriteLine("------------------------LIST 2-------------------------------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2); // Remove primeiro a posição e depois o elemento. Posição dois e dois elementos.
            Console.WriteLine("------------------------------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(3); // Remove o elemento nessa posição
            Console.WriteLine("------------------------------------------------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M'); // remove todos que começem com a letra M
            Console.WriteLine("------------------------------------------------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex"); // Remove = Remova o elemento que eu selecionar
            Console.WriteLine("------------------------------------------------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}