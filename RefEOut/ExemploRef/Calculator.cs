namespace Exemplo
{
    public class Calculator
    {
        public static void Triple(ref int x){
            x = x * 3; 
        }
        // aqui falamos que a variável x faz referência a variável 'a'. Caso não tenha o ref, a variável passa pela a operação
        // Porém, ela não tem onde ser armazenada, então ela some. 
    }
}