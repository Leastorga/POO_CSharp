# Encapsulamento 📚

Encapsulamento é o ato de criar objetos ou estruturas de dados que têm detalhes internos (dados e métodos), mas você os "encapsula" para que outros programadores que usem esses objetos só possam interagir com eles por meio de métodos e propriedades específicos, em vez de acessar diretamente seus detalhes internos. Isso ajuda a tornar seu código mais organizado, seguro e fácil de manter, porque você pode controlar como os dados são usados e modificados.

### Exemplo:

Para entender de forma mais fácil, imagine um carro. O carro tem várias partes internas, como o motor, a transmissão e os freios. Essas partes internas são "encapsuladas" dentro do carro. Você não precisa saber todos os detalhes complexos do funcionamento do motor para dirigir o carro. Em vez disso, você interage com o carro por meio de uma interface simples, como o volante, os pedais e a alavanca de câmbio.

# Opção 1 - Implementação manual

- Todo atributo é definido como private
- Implementa-se métodos Get e Set para cada atributo, conforme regras de negócio
- NÃO É USUAL NA PLATAFORMA C#

OBS: Por convenção no C# Atributos privados salvamos com: _nomeDoAtributo