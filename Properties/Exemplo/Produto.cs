using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome; //Atributo
        private double _preco; //Atributo
        private int _quantidade; //Atributo

        public Produto()
        { //Construtor padrão
        }
        public Produto(string nome, double preco, int quantidade) //Construtor com Três argumentos
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome;}
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }

        }

        public double Preco{
            get {return _preco;}

        }

        public int Quantidade{
            get{return _quantidade;}
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