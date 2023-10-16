# Modificador de parâmetros: ref e out

### Ref

O modificador **`ref`** em C# é usado para passar um argumento por referência para um método. Isso significa que, quando você passa um argumento com **`ref`** para um método, qualquer modificação feita no parâmetro dentro do método também afetará a variável original que foi passada como argumento.

### OutraClass.cs

```csharp
public void ModificarValor(ref int numero)
{
    numero = numero * 2;
}
```
### Program.cs

```csharp
int valor = 5;
ModificarValor(ref valor);
Console.WriteLine(valor); // Isso imprimirá "10" porque o valor foi modificado dentro do método
```
---
### Out

O modificador **`out`** em C# é semelhante ao **`ref`**, mas com algumas diferenças importantes. O **`out`** é usado para passar argumentos para um método de forma que o método possa atribuir um valor a essa variável antes de retornar.

a principal diferença entre **`ref`** e **`out`** é que com **`ref`**, você deve atribuir um valor à variável antes de passá-la para o método, enquanto com **`out`**, o método é obrigado a atribuir um valor à variável dentro do método.

### OutraClasse.cs

```csharp
public void ObterValor(out int resultado)
{
    resultado = 42; // Obrigatório atribuir um valor antes de retornar
}
```

### Program.cs

```csharp
int valor;
ObterValor(out valor);
Console.WriteLine(valor); // Isso imprimirá "42", pois o método atribuiu esse valor
```

### Ambos são considerador "code smells" (design ruim ) e devem ser evitador.