using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExecFixacao.Entities.Exception;

namespace ExecFixacao.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; } //Titular
        public double Balance { get; set; } // saldo
        public double WithdrawLimit { get; set; } // Limite de retirada 

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            Balance -= amount;
            if (Balance < 0.0)
            {
                throw new DomainException("Not enough balance");
            }

        }
    }
}