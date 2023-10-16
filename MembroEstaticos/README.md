# Membros Estáticos 📚

Também são chamados membros de classe.

São membros que fazem sentido independentemente de objetos. Não precisam de objeto para serem chamados. São chamados a partir do próprio nome da classe.

Aplicações comuns:
```
    - Classes utilitárias
    - Declaração de constantes
```    

Uma classe que possui somente membros estáticos, pode ser uma classe estática também. Esta classe não poderá ser instanciada.

Exemplicação simples:

Por exemplo, se a sua receita (classe) para cookies tiver uma quantidade fixa de açúcar (um membro estático), todos os cookies que você fizer a partir dessa receita terão exatamente a mesma quantidade de açúcar, não importa quantos cookies você faça (quantas instâncias da classe você crie). O açúcar é "estático" porque não muda de um cookie para outro; ele é compartilhado por todos os cookies que você assa com base nessa receita.