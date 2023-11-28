using ExecFixacao.Entities;

namespace ExecFixacao.Services
{
    class ContractService
    {
        private IOnlinePaymentService _OnlinePaymentService;

        public ContractService(IOnlinePaymentService _onlinePaymentService){
            _OnlinePaymentService = _onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months){
            double basicQuota = contract.TotalValue / months;

            for (var i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _OnlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuota + _OnlinePaymentService.PaymentFee(updateQuota);
                contract.AddInstallments(new Installment(date, fullQuota));
            }
        }
    }
}