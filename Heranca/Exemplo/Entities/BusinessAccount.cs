using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.Entities
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Ioan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

    }
}