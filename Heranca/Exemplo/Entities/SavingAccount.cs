using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.Entities
{
    public class SavingAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance (){
            Balance += Balance * InterestRate;
        }
        

        

    }
}