using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Hw09.RegFold
{
    class Airport
    {
        public void CheckInNow(Passenger passenger)
        {
            Console.WriteLine("Enter your passport number in this format \"AB123456\" : ");
            Link: passenger.Passport = Console.ReadLine();
            while (Regex.IsMatch(passenger.Passport, @"[a-zA-Z]{2}\d{6}") != true)
            {
                Console.WriteLine("You must to enter your passport number in correct way.");
                goto Link;
            }
            while (passenger.Passport.Length != 8)
            {
                Console.WriteLine("You must to enter your passport number in correct way.");
                goto Link;
            }
            Console.WriteLine("Enter your ticket number \"4 numbers\" : ");
            link2: passenger.Ticket = int.Parse(Console.ReadLine());
            while (passenger.Ticket < 1000 || passenger.Ticket > 9999)
            {
                Console.WriteLine("You must to enter your ticket number in correct way.");
                goto link2;
            }
            Random rnd = new Random();
            string[] arrayPlace = new string[rnd.Next(1, 10)];
            for (int i = 0; i < arrayPlace.Length; i++)
            {
                arrayPlace[i] = $"{rnd.Next(1,50)}{(char)rnd.Next('A','F')}";
            }
            Console.WriteLine("Do you want to choose a seat? y/n");
            Link3: switch (Console.ReadLine())
            {
                case "Y":
                case "y":
                    Console.WriteLine("There are avaliable seats:");
                    int count=0;
                    for (int i = 0; i < arrayPlace.Length; i++)
                    {
                        count++;
                        Console.WriteLine(count + " - " + arrayPlace[i]);
                    }
                    passenger.Seat = arrayPlace[int.Parse(Console.ReadLine())-1];
                    break;
                case "N":
                case "n":
                    passenger.Seat = $"{rnd.Next(1, 50)}{(char)rnd.Next('A', 'F')}";
                    break;
                default:
                    Console.WriteLine("Incorrect!");
                    goto Link3;
            }
            passenger.Gate = rnd.Next(1, 20);
            Luggage luggage = new Luggage();
            luggage.QuestionPassenger(passenger);
        }
    }
}
