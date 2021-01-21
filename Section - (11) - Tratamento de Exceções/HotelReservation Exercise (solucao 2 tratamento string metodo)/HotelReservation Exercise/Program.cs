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

            Console.Write("Check-in date (dd/mm/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/mm/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.Write("Check-in date must be after check-out date.");
            }

            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.Write("Reservation: " + reservation);

                Console.WriteLine();


                Console.WriteLine("Enter data to update reservation: ");
                Console.Write("Check-in date (dd/mm/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/mm/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkIn, checkOut);
                if (error != null)
                {
                    Console.WriteLine(error);
                }
                else
                {
                    Console.WriteLine("Reservation: " + reservation);
                }

            }
        }
    }
}


    
