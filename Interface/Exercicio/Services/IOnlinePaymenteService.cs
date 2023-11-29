using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio.Services
{
    interface IOnlinePaymenteService
    {
        double Paymentfee(double amount);
        double Interest(double amount, int months);

    }
}