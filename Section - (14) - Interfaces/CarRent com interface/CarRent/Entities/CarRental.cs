using System;
using System.Collections.Generic;
using System.Text;
using CarRent.Exceptions;

namespace CarRent.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            if (start > finish)
            {
                throw new DomainException("Error: pickUp date must be earlier than return date.");
            }
            
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
