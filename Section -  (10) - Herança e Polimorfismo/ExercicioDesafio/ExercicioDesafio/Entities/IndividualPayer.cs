using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDesafio.Entities
{
    class IndividualPayer : Payer
    {
        public double HealtExpenditures { get; set; }

        public IndividualPayer(double anualIncome, string name, double healthExpenditures) : base(anualIncome, name)
        {
            HealtExpenditures = healthExpenditures;

        }

        public override double Taxes()
        {
            double sum = 0;
            sum -= HealtExpenditures / 2;

            if (AnualIncome <= 20000)
            {
                sum += AnualIncome * 0.15;
            }
            else if (AnualIncome > 20000)
            {
                sum += AnualIncome * 0.25;
            }

            return sum;
        }

    }
}
