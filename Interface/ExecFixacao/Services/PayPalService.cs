
namespace ExecFixacao.Services
{
    class PayPalService : IOnlinePaymentService
    {
        public double PaymentFee(double mount){
            return mount * 0.02;
        }
        
        public double Interest(double amount, int months){
            return amount * 0.01 * months; 
        }
    }
}