using System;
using Exercicio_Fixação_Exceptions___Conta_Bancaria.Entities.Exceptions;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixação_Exceptions___Conta_Bancaria.Entities
{
    class Account
    {

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

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

        public void WithDraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("You dont have this amount of balance to withdraw");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw limit exceededed");
            }

            Balance -= amount;
        }




    }
}
