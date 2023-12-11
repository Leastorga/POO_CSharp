namespace Pratica.Services
{
    public class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y; // Operador ternário: condicao ? expressao_se_verdadeiro : expressao_se_falso;

        }

        public static double Sum(double x, double y){
            return x + y;
        }

        public static double Square(double x){
            return x * x;
        }
    }
}