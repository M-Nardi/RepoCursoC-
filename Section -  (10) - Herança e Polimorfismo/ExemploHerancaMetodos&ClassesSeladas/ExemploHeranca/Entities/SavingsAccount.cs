using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploHeranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) //selada para nao poder ser utilizado novamente o metodo por outras subclasses
        {
            base.Withdraw(amount);
            Balance -= 2.0; // taxa diferente por ser conta poupança

        }
    }
}
