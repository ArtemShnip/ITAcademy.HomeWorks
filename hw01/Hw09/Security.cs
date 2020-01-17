using System;
using System.Collections.Generic;
using System.Text;

namespace Hw09
{
    class Security
    {
        public void Securi(Passenger passenger)
        {
            Console.WriteLine($"Check your information : {passenger.ToString()}\n Press enter.");
            Console.ReadLine();
            Console.WriteLine("Please put your staff on the table. Do you have any illegal staff? y or n");
            Console.ReadLine();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine();
            Random rnd = new Random();
            int drug = rnd.Next(1,10);
            Departure dep = new Departure();
            if (drug > 7)
            {
                Console.WriteLine("Are these drugs and weapon yours?");
                dep.NoDep(passenger);
            }
            else
            {
                Console.WriteLine($"Please go to your Gate {passenger.Gate}");
                dep.DepPass(passenger);
            }
        }
    }
}
