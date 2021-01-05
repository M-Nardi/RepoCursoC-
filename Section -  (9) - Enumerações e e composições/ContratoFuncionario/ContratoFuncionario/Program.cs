using System;
using ContratoFuncionario.Entities.Enums;
using ContratoFuncionario.Entities;
using System.Collections.Generic;

namespace ContratoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.Write("Enter the department's name:");
            string departmentName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary ex: (R$1500,00): R$");
            double workerBaseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(departmentName);
             
            Worker worker = new Worker(workerName,workerLevel,workerBaseSalary,dept);

            Console.Write("How many contracts this worker have? :");
            int contractAmount = int.Parse(Console.ReadLine());

            int contractCount = 1;
            while (contractAmount >= contractCount)
            {
                Console.WriteLine("Enter #" + contractAmount + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour ex: (R$30,00) : R$");
                double contractValueHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int contractHours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(contractDate, contractValueHour, contractHours);

                worker.AddContract(contract);

                contractCount++;
            }

            Console.Write("Enter the month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            
            Console.WriteLine();
            Console.WriteLine("Name:" + worker.Name);
            Console.WriteLine("Department:" + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": R$" + worker.Income(year,month));

            Console.ReadLine();


        }
    }
}
