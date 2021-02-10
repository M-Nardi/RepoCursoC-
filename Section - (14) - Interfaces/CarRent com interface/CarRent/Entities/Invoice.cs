using System;
using System.Collections.Generic;
using System.Text;

namespace CarRent.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return
                "Basic Payment: R$" + BasicPayment.ToString("F2") +
                "\nTax: R$" + Tax.ToString("F2") +
                "\nTotal Payment: R$" + TotalPayment.ToString("F2");
        }
    }
}
