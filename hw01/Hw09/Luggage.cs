using System;
using System.Collections.Generic;
using System.Text;

namespace Hw09
{
    class Luggage : Registrations
    {
        public void Luggag(Passenger passenger)
        {
            Random rnd = new Random();
            passenger.WeightLuggage =rnd.Next(1, 100);
            if (passenger.WeightLuggage > 30)
            {
                Console.WriteLine($"\nВес вашего багажа {passenger.WeightLuggage} , вам надо заплатить 5$ за каждый килограмм");
                int summa = (passenger.WeightLuggage - 30) * 5;
                Console.WriteLine($"С вас {summa}$"); 
            }
            if (passenger.WeightLuggage < 30)
            {
                Console.WriteLine($"\nВес вашего багажа {passenger.WeightLuggage}");
            }
            Security security = new Security();
            security.Securi(passenger);
        }
    }
}
