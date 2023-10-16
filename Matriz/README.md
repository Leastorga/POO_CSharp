# Matriz

Em programação, “matriz” é o nome dado a arranjos bidimensionais

Arranjo é uma estrutura de dados:

- Homegênea(dados do mesmo tipo)
- Ordenada(Elementos acessados por meio de posições)
- Alocada de uma vez só, em um bloco contíguo de memória

### Vantagens

- Acesso imediato aos elementos pela sua posição

### Desvantagens

- Tamanho fixo
- Dificuldade para se realizar inserções e deleções

```csharp
namespace Exemplo
{
    class Program
    {
        public static void Main(string[] args)
        {
            double [,] mat = new double[2,3];

            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);

            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
```