using System;
using System.Collections.Generic;
using System.Text;

namespace Hw09
{
    class Luggage
    {
        public void QuestionPassenger(Passenger passenger)
        {
            Console.WriteLine("\nDo you have any luggage? \n1. yes \n2. no");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Please put your luggage on a scale.");
                    System.Threading.Thread.Sleep(500);
                    WeightLuggage(passenger);
                    break;
                default:
                    Console.WriteLine("1 or 2");
                    Security security = new Security();
                    security.Securi(passenger);
                    break;
            }
            
        }
        public void WeightLuggage(Passenger passenger)
        {
            Random rnd = new Random();
            passenger.WeightLuggage =rnd.Next(1, 100);
            if (passenger.WeightLuggage > 30)
            {
                Console.WriteLine($"\nYour lugguage weight is {passenger.WeightLuggage}. You have to pay 5$ for every exstra kilogram.");
                int summa = (passenger.WeightLuggage - 30) * 5;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine($"Please pay {summa}$"); 
            }
            if (passenger.WeightLuggage < 30)
            {
                Console.WriteLine($"\nWeight of your lugguage is {passenger.WeightLuggage}\n");
            }
            System.Threading.Thread.Sleep(500);
            Console.WriteLine();
            Security security = new Security();
            security.Securi(passenger);
        }
    }
}
