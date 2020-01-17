using System;
using System.Collections.Generic;
using System.Text;

namespace Hw09.RegFold
{
    class Online
    {
        public void CheckInOnline(Passenger passenger)
        {
            Console.WriteLine("\nEnter your ticket number \"4 numbers\" : ");
            passenger.Ticket = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            passenger.Passport = $"{(char)rnd.Next('A', 'Z' + 1)}{(char)rnd.Next('A', 'Z' + 1)}{rnd.Next(100000, 999999)} ";
            passenger.Gate = rnd.Next(1, 20);
            passenger.Seat = $"{rnd.Next(1, 50)}{(char)rnd.Next('A', 'F')}";
            Luggage luggage = new Luggage();
            luggage.QuestionPassenger(passenger);
        }
    }
}
