using System;
using System.Globalization;
using CarRent.Entities;
using CarRent.Exceptions;
using CarRent.Services;

namespace CarRent
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Enter rental data:");

            Console.Write("Car Model: ");
            string carModel = Console.ReadLine();

            Console.Write("PickUp date (dd/mm/yyyy hh:mm): ");
            DateTime pickUpDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return date (dd/mm/yyyy hh:mm): ");
            DateTime returnDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: R$");
            double hourPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter price per day: R$");
            double dayPrice = double.Parse(Console.ReadLine());

            CarRental rent = new CarRental(pickUpDate, returnDate, new Vehicle(carModel));

            RentalService rentalService = new RentalService(hourPrice, dayPrice);

            rentalService.ProcessInvoice(rent);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(rent.Invoice);

            }

            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
