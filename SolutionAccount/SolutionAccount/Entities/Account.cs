using System;
using System.Collections.Generic;
using System.Text;
using SolutionAccount.Entities.Exeptions;

namespace SolutionAccount.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainExeption("Withdraw error: The amount exceeds withdraw limit");
            }
            if(Balance < amount)
            {
                throw new DomainExeption("Withdraw error: Not enough balance");
            }
            Balance -= amount;
        }
    }
}
