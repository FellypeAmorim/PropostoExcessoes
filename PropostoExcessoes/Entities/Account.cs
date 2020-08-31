using PropostoExcessoes.Entities.Exeptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropostoExcessoes.Entities
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

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance -= amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainExeptions("Withdraw error: The amount exceeds withdraw limit");
            }
            if (Balance < amount)
            {
                throw new DomainExeptions("Not enough balance");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return "New Balance: " + Balance.ToString("F2");
        }

    }
}
