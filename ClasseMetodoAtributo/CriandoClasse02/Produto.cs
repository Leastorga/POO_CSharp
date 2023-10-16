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

        public void AdicionarProdutos(int quantidade){
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade){
            Quantidade -= quantidade;
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