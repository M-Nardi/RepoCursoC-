using System;
using ExercicioResolvido.Entities;
using System.Collections.Generic;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            
            Console.Write("Enter the number of employees: ");
            int amount = int.Parse(Console.ReadLine());

            int employeesCount = 1;
            while (employeesCount <= amount)
            {

                Console.WriteLine("Employee #" + employeesCount + " data:");
                Console.Write("Outsourced (y/n)? : ");
                string employeeOutsourced = Console.ReadLine();

                Console.Write("Name: ");
                string employeeName = Console.ReadLine();

                Console.Write("Hours: ");
                int employeeHours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour : R$");
                double employeeValuePerHour = double.Parse(Console.ReadLine());

                if (employeeOutsourced == "y")
                {
                    Console.Write("Aditional Charge : R$");
                    double employeeCharge = double.Parse(Console.ReadLine());

                    Employee employee = new OutsourcedEmployee(employeeName, employeeHours, employeeValuePerHour, employeeCharge);
                    employees.Add(employee);
                }

                else
                {
                    Employee employee = new Employee(employeeName, employeeHours, employeeValuePerHour);
                    employees.Add(employee);
                }

                employeesCount++;

            }

            Console.WriteLine();

            foreach (Employee employee in employees)
            {
                Console.Write(employee.Name + " - R$ " + employee.Payment(employee.Hours, employee.ValuePerHour).ToString("F2"));
                Console.WriteLine();
            }

        }
    }
}
