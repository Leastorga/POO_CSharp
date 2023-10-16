using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome; //Atributo sem auto properties pois possui uma lógica 
        public double Preco{get; private set;} //Atributo com auto properties
        public int Quantidade{get; private set;} //Atributo com auto properties

        public Produto()
        { //Construtor padrão
        }
        public Produto(string nome, double preco, int quantidade) //Construtor com Três argumentos
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }

        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}