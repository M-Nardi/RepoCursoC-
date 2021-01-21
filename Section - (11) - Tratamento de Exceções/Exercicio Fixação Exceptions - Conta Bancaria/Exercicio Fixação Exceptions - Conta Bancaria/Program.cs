using System;
using Exercicio_Fixação_Exceptions___Conta_Bancaria.Entities;
using Exercicio_Fixação_Exceptions___Conta_Bancaria.Entities.Exceptions;
namespace Exercicio_Fixação_Exceptions___Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");

                Console.Write("Number: ");
                int accountNumber = int.Parse(Console.ReadLine());

                Console.Write("Holder name: ");
                string accountHolder = Console.ReadLine();

                Console.Write("Initial balance: $");
                double accountBalance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: $");
                double accountWithdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(accountNumber, accountHolder, accountBalance, accountWithdrawLimit);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: $");
                double withdrawAmount = double.Parse(Console.ReadLine());

                account.WithDraw(withdrawAmount);
                Console.WriteLine("New balance: $" + account.Balance.ToString("F2"));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Operation Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e.Message);
            }


        }
    }
}

