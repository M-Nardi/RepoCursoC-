using System;
using System.Collections.Generic;

namespace S06ListaProgramaFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Funcionario> employees = new List<Funcionario>();
            
            Console.Write("How many employees will be registered? ");
            int qtdEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdEmployees; i++)
            {
                int employeeNumber = i + 1;
                Console.WriteLine("Employee #" + employeeNumber);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                int salary = int.Parse(Console.ReadLine());

                Funcionario employeeData = new Funcionario { Id = id, Name = name, Salary = salary };

                employees.Add(employeeData);

                Console.WriteLine("");

            }

            Console.Write("Enter the employee Id that will have salary increase: ");
            int searchID = int.Parse(Console.ReadLine());

            Funcionario searchResult = employees.Find(x => x.Id == searchID);

            if (searchResult != null)
            {
                Console.Write("Enter the percentage: ");
                double percentageIncrease = double.Parse(Console.ReadLine());
                searchResult.IncreaseSalary(percentageIncrease);
            }
            else
            {
                Console.WriteLine("ID inexistente");
            }

            Console.WriteLine("Updated list of employees: ");
            
            foreach (Funcionario obj in employees)
            {
                Console.WriteLine(employees);
            }
            
            

            

            











        }
    }
}
