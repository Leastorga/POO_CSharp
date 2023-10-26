# Polimorfismo

Polimorfismo é a utilização de um mesmo método em contextos diferentes, onde cada objeto criado pode usar esse método, mas com uma implementação específica, atendendo a um objetivo particular.

Um exemplo é:

```csharp
class Animal
{
    public void FazerBarulho()
    {
        Console.WriteLine("O animal faz um som.");
    }
}

class Cachorro : Animal
{
    public void FazerBarulho()
    {
        Console.WriteLine("O cachorro late.");
    }
}

class Gato : Animal
{
    public void FazerBarulho()
    {
        Console.WriteLine("O gato mia.");
    }
}
```

### Outro exemplo é:

```csharp
Account acc1 = new Account(1001, "Alex", 500.0);
Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
```

![Untitled](img/accountExemplo.png)

Ambos os objetos são do mesmo tipo (Account) porém os objetos possuem características diferentes.
