# File, FileInfo e IOException

- File, FileInfo são classes que pertencem ao namespace System.IO
- Realiza operações com arquivos (cria, copia, deleta, move, abre, etc…) e ajuda na criando de objetos FileStream

> FileStream: É uma classe que lê e escrever bytes em arquivos.
Você usaria um **`FileStream`** sempre que precisasse ler ou escrever dados em um arquivo, especialmente se estivesse trabalhando com arquivos binários ou precisasse de controle detalhado sobre como os dados são lidos ou escritos.
> 

---

### File

A classe File é mais simples, possui operações static, ou seja, não é necessário instância. Por outro lado, é mais lento que  fileInfo por realiza verificações de segurança para cada operação.

### FileInfo

É necessário instanciar o objeto e chamar as operações dentro dele. Mais rápida que o file.

### Quando usar cada um?

Quando for uma operação simples e não é relevante o desempenho usamos o file, porém se for uma programa que possui muitas operações e precisa de desempenho utilizamos o fileinfo.

---

### IOException

Super classe de todas as exceções que podem acontecer quando estamos lidando com arquivos.