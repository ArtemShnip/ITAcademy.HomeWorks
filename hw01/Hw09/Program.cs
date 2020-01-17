using System;
using Hw09.RegFold;

using System.Collections.Generic;
namespace Hw09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We glad to see you in Airlines!");
            Passenger passenger = new Passenger();
            Console.WriteLine("What is your name?");
            passenger.Name = Console.ReadLine();
            Console.WriteLine("Have you booked on website yet or do you want to check in now?");
            Console.WriteLine("1. I have booked on website. \n2. I want to check in now.");            
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Online online = new Online();
                    online.CheckInOnline(passenger);
                    break;
                case 2:                    
                    Airport airport = new Airport();
                    airport.CheckInNow(passenger);
                    break;
                default:
                    Console.WriteLine("1 or 2");
                    break;
            }
        }
    }
}