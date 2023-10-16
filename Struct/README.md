### Structs são tipos valor

A linguagem C# também possui tipos valor, que são “structs”. Structs são CAIXAS e não ponteiros.

```csharp
double x, y;
x = 10;
y = x;
```

### é possível criar seus próprios structs

```csharp
namespace Explicacao
{
    struct Point
    {
        public double X, Y;

        public override string ToString(){
            return "(" + X + "," + Y + ")";
        }
    }
}
```

### Utilizando a Struct

```csharp
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
        }
    }
}
```