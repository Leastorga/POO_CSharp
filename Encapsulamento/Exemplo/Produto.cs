using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome; //Atributo
        private double _preco; //Atributo
        private int _quantidade; //Atributo // O private garante que esse atributo não seja acessível para outra classe

        public Produto()
        { //Construtor padrão
        }
        public Produto(string nome, double preco, int quantidade) //Construtor com Três argumentos
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco(){
            return _preco;
        }

        public int GetQuantidade(){
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}