# Auto Properties

É uma forma simplifica de se declarar propriedades que não necessitam lógicas particulares para as operações get e set.
O compilador cuida dos detalhes de implementação dos métodos "get" e "set", tornando o código mais conciso. As auto properties são especialmente úteis quando você não precisa de lógica personalizada para acessar ou modificar o valor da propriedade e deseja apenas definir e ler valores simples.

```csharp
public double Preco { get; private set;}
```

OBS: Quando temos um properties que possui lógica, não utilizamos a auto propertie.