namespace ExecFixacao.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double mount);
        double Interest(double amount, int months);
    }
}