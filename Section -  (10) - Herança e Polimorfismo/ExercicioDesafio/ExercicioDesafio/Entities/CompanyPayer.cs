using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDesafio.Entities
{
    class CompanyPayer : Payer
    {

        public int EmployeesNumber { get; set; }

        public CompanyPayer (double anualIncome, string name, int employeesNumber) : base (anualIncome, name)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double Taxes()
        {
            double sum = 0;

            if (EmployeesNumber <= 10)
            {
                sum += AnualIncome * 0.16;
            }
            else if (EmployeesNumber > 10)
            {
                sum += AnualIncome * 0.14;
            }

            return sum;
        }



    }
}
