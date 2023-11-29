using System;
using Exercicio.Entities;



namespace Exercicio.Services
{
    class ContractService
    {
        private IOnlinePaymenteService _IOnlinePaymenteService;

        public ContractService(IOnlinePaymenteService _iOnlinePaymentService)
        {
            _IOnlinePaymenteService = _iOnlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for(int i = 1; i <= months ; i++)
            {
                DateTime date = contract.Date.AddMonths(i);    
                double UpdatedQuota = basicQuota + _IOnlinePaymenteService.Interest(basicQuota, i);
                double fullQuota = UpdatedQuota + _IOnlinePaymenteService.Paymentfee(UpdatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}