using System;

using System.Collections.Generic;
namespace Hw09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Мы рады приветсвовать вас в  Airlines!");
            Passenger passenger = new Passenger();
            Registrations registrations = new Registrations();
            registrations.Registr(passenger);
        }
    }
}
