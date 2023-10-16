# Criação de classes, métodos e atributos 📚

## Classes

É um tipo estruturado que pode conter (membros) :

- Atributos (dados/campos)
- Métodos (funções/ Operações)

A classe também pode prover muitos outros recursos, tais como:

- Construtores
- Sobrecarga
- Encapsulamento
- Herança
- Poliformo

Exemplo:
- Entidades: Produto, Cliente, Triangulo
- Serviços: ProdutoService, ClienteService, EmailService, StorageService
- Controladores: ProdutoController, ClienteController
- Utilitários: Calculadora, Compactador
- Outros (views, repositórios, gerenciadores, etc.)

## Métodos

No exemplo da criação do triângulo, criamos uma classe entidade triângulo e colocamos as variáveis que precisassem ser armazenadas. Porém, como queremos fazer um calculo com os dados armazenados dentro das variáveis, iremos criar um método para que no programa principal apenas seja necessário chamar, sem precisar criar no programa principal.

Criação de método dentro de uma classe:
```csharp
namespace SemPOO
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p- A) * (p - B) * (p - C));
            
        }

    }
}
```

## Object e ToString

Toda classe em C# é uma subclasse da classe Object

- Object possui os seguintes métodos:
    - GetType - retorna o tipo do objeto
    - Equals - Compara se o objeto é igual a outro
    - GetHashCode - retorna um código hash do objeto
    - ToString - Converte o objeto para string

> Pelo o que entendi, usamos esse método para que apenas seja necessário chamar a variável que colocamos dentro da nossa classe que armazena as informações de um produto por exemplo. Assim, podemos formatar pela nossa necessidade o que deverá ser dito e só editamos caso precise de alguma mudança. Veja o exemplo.3
> 

Dentro da classe produto:
```csharp
using System;
using System.Globalization;

namespace CriandoClasse02
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome 
            + ", $ " 
            + Preco.ToString("F2", CultureInfo.InvariantCulture) 
            + ", "
            + Quantidade
            + " Unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
            ;
        }
    }
}
```
## Membros Estáticos

Também são chamados membros de classe

São membros que fazem sentido independentemente de objetos. Não precisam de objeto para serem chamados. São chamados a partir do próprio nome da classe.

- Aplicações comuns:
    - Classes utilitárias
    - Declaração de constantes
- Uma classe que possui somente membros estáticos, pode ser uma classe estática também. Esta classe não poderá ser instanciada.