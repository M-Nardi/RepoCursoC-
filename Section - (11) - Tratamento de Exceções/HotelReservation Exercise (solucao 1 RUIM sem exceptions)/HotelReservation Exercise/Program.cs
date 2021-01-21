using System;
using HotelReservation_Exercise.Entities;

namespace HotelReservation_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Room number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Check-in date (dd/mm/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Check-out date (dd/mm/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Check-in date must be after check-out date.");
            }

            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();


                Console.WriteLine("Enter data to update reservation: ");
                Console.WriteLine("Check-in date (dd/mm/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-out date (dd/mm/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;

                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation, dates for update must be future dates");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Check-in date must be after check-out date.");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }

            }
        }
    }
}


    
