﻿using Exceções_Personalizadas.Entities;
using System;


namespace Exceções_Personalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Write Number room: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Check-In Date (dd / MM / yyyy)");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Check-Out Date (dd / MM / yyyy)");
            DateTime checkout = DateTime.Parse(Console.ReadLine());


            Reservation reservation = new Reservation(number, checkin, checkout);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine("Enter data to update the reservation:");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkin = DateTime.Parse(Console.ReadLine());


            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkout = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkin, checkout);
            Console.WriteLine("Reservation: " + reservation);


            }


            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }

            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}
