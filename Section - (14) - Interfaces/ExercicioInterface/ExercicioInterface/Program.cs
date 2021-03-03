using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioInterface.Entities;
using ExercicioInterface.Services;

namespace ExercicioInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter contract data: ");
            Console.Write("Number:" );
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/mm/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract Value: $ ");
            double contractValue = double.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, contractDate, contractValue);

            Console.Write("Enter the number of installments: ");
            int installments = int.Parse(Console.ReadLine());


            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, installments);

            foreach (Installment installment in contract.Installment)
            {
                Console.WriteLine(installment);
            }


            


        }
    }
}
