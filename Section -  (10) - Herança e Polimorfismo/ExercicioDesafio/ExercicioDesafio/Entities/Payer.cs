using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDesafio.Entities
{
    abstract class Payer
    {
        public double AnualIncome { get; set; }
        public string Name { get; set; }

        public Payer()
        {
        }

        public Payer(double anualIncome, string name)
        {
            AnualIncome = anualIncome;
            Name = name;
        }

        public abstract double Taxes();

    }
}
