using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvido.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }


        Employee() { }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment(int hours, double valuePerHour)
        {
            double paymentValue = hours * valuePerHour;
            return paymentValue;
        }

    }
}
