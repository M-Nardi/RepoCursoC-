using System;
using ExercicioDesafio.Entities;
using System.Collections.Generic;

namespace ExercicioDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int payerAmount = int.Parse(Console.ReadLine());

            int payerCount = 1;
            while (payerCount <= payerAmount)
            {
                Console.WriteLine("Tax payer #" + payerCount + " data:");

                Console.Write("Individual or Company (i/c)? ");
                char payerType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string payerName = Console.ReadLine();

                Console.Write("Anual Income: R$");
                double payerIncome = double.Parse(Console.ReadLine());

                if (payerType == 'i')
                {
                    Console.Write("Health Expenditures: R$");
                    double healtExpenditures = double.Parse(Console.ReadLine());

                    list.Add(new IndividualPayer(payerIncome, payerName, healtExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int amountEmployees = int.Parse(Console.ReadLine());

                    list.Add(new CompanyPayer(payerIncome, payerName, amountEmployees));
                }


                payerCount++;
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double totalTaxes = 0;

            foreach (Payer payer in list)
            {
                Console.WriteLine(payer.Name + ": R$ " + payer.Taxes().ToString("F2"));
                totalTaxes += payer.Taxes();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: R$" + totalTaxes.ToString("F2"));


        }
    }
}
