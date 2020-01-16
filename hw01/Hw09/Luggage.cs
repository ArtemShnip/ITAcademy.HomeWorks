using System;
using System.Collections.Generic;
using System.Text;

namespace Hw09
{
    class Luggage : Registrations
    {
        public void Luggag()
        {
            Random rnd = new Random();
             int weight =rnd.Next(1, 100);
            if (weight > 30)
            {
                Console.WriteLine($"Вес вашего багажа {weight} , вам надо заплатить 5$ за каждый килограмм");
                int summa = (weight - 30) * 5;
                Console.WriteLine($"С вас {summa}$");
            }
            else
            {
            }
            
        }
    }
}
