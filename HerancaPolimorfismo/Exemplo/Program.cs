using System;
using Exemplo.Entities;

namespace Exemplo {
    class Program {
        static void Main(string[] args) {

            Account acc = new(1001, "Alex", 0.0);
            BusinessAccount bacc = new(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003,"Bob", 0.0, 200.00);
            Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

            // DOWCASTING == Operação insegura

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            // BusinessAccount acc5 = (BusinessAccount) acc3; // Duas subclasses
            if (acc3 is BusinessAccount){
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingAccount)
            {
                // SavingAccount acc5 = (SavingAccount) acc3;
                SavingAccount acc5 = acc3 as SavingAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}