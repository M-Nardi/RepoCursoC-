using System;
using HotelReservation_Exercise.Entities;
using HotelReservation_Exercise.Entities.Exceptions;

namespace HotelReservation_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/mm/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/mm/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());



                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.Write("Reservation: " + reservation);

                Console.WriteLine();


                Console.WriteLine("Enter data to update reservation: ");
                Console.Write("Check-in date (dd/mm/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/mm/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
                
        }
    }
}



