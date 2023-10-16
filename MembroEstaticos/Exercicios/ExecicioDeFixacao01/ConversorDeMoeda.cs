
namespace ExecicioDeFixacao01
{
    public class ConversorDeMoeda
    {

        public static double Iof = 6.0;
        public static double Cotacao(double valor, double qtd)
        {
            return (valor * qtd) + valor * qtd * Iof / 100.0;
        }

    }
}