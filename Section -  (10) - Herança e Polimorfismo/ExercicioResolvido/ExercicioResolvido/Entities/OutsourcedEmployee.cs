using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvido.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AditionalCharge { get; set; }


        public OutsourcedEmployee(string name, int hours, double valuePerHour, double aditionalCharge)
            : base(name, hours, valuePerHour) 
        {
            AditionalCharge = aditionalCharge;
        }
        
        
        public override double Payment(int hours, double valuePerHour)
        {
            double paymentValue = base.Payment(hours, valuePerHour);
            double paymentValueWithCharge = paymentValue + (AditionalCharge * 1.1);
            return paymentValueWithCharge;
        }


    }
}
