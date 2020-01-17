using System;
using System.Collections.Generic;
using System.Text;

namespace Hw09
{
    class Departure
    {
        public void DepPass(Passenger passenger)
        {
            Console.WriteLine($"\nEnjoy your flight! {passenger.Name}");
        }
        public void NoDep(Passenger passenger)
        {
            Console.WriteLine("Wellcome to prison!");
        }
    }
}
