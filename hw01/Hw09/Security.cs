using System;
using System.Collections.Generic;
using System.Text;

namespace Hw09
{
    class Security
    {
        public void Securi(Passenger passenger)
        {
            Console.WriteLine("\nSecurity -> " + passenger.ToString());
            departure departure = new departure();
            departure.dep(passenger);
        }
    }
}
