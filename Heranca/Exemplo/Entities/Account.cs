using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.Entities
{
    public class Account
    {


        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void WithDraw(double amount){
            Balance -= amount;
        }

        public void Deposit(double amount){
            Balance += amount;
        }

    }
}