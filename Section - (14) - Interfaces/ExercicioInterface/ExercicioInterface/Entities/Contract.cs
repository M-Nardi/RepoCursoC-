using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;


namespace ExercicioInterface.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public Double TotalValue { get; set; }
        public List<Installment> Installment { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installment = new List<Installment>();
        }

        public void AddInstallment (Installment installment)
        {
            Installment.Add(installment);
        }
    }
}
