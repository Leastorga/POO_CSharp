using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio.Services
{
    class PaypalService : IOnlinePaymenteService
    {
        public double Paymentfee(double amount){
           return amount * 0.02; 
        }

        public double Interest(double amount,int months){
            return amount * 0.01 * months; 
        }
    }
}