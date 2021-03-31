using System;
using System.Linq;
using System.Collections.Generic;
using ExercicioFixação.Entities;
using System.IO;
using System.Globalization;


namespace ExercicioFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Input .csv path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] lines = sr.ReadLine().Split(",");
                        string empName = lines[0];
                        string empEmail = lines[1];
                        double empSalary = double.Parse(lines[2], CultureInfo.InvariantCulture);

                        employees.Add(new Employee(empName, empEmail, empSalary));
                    }

                    Console.Write("Enter salary: ");
                    double salarySearch = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Email of people that salary is more than: R$" + salarySearch);

                    var emailSalary = employees.Where(p => p.Salary > 2000).OrderBy(p => p.Email).Select(p => p.Email);

                    foreach (string email in emailSalary)
                    {
                        Console.WriteLine(email);
                    }
                    Console.WriteLine();

                    var sumCharM =
                        (from p in employees
                         where p.Name[0] == 'M'
                         select p.Salary).Sum();

                    Console.WriteLine("Sum of salary of people that name starts with 'M': " + sumCharM.ToString("F2",CultureInfo.InvariantCulture));

                }
            }



            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
