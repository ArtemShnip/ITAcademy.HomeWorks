using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Hw09
{
    class Registrations
    {
        public void Registr()
        {
            Passenger passenger = new Passenger();
            Luggage luggage = new Luggage();
            Console.WriteLine("Как Вас зовут?");
            passenger.Name = Console.ReadLine();
            Console.WriteLine("Вы уже прошли регистрацию через интернет или желаете пройти её здесь.\n1. Зарегестрировался в интернете \n2. Пройти регестрацию на месте");
            int regStatus = int.Parse(Console.ReadLine());
            if (regStatus == 1)
            {
                Console.WriteLine("Введите номер паспорта \"AB123456\" : ");
                string pasport = Console.ReadLine();
                if (Regex.IsMatch(pasport, @"[a-zA-Z]{2}\d{6}"))
                {
                    passenger.Pasport = pasport;
                    Random rnd = new Random();
                    passenger.Ticket = rnd.Next(1, 1000);
                    passenger.Gate = rnd.Next(1, 20);
                    Console.WriteLine("Вы путешествуете с багажом? \n1. да \n2. нет");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine("Поставте багаж на весы");
                            luggage.Luggag();
                            Console.WriteLine($"проходите к выходу {passenger.Gate}");
                            break;
                        case 2:
                            Console.WriteLine($"проходите к выходу {passenger.Gate}");
                            break;
                        default:
                            Console.WriteLine("да(1) или нет(2)");
                            break;
                    }
                    
                    
                }
                else Console.WriteLine("Введите коректно номер паспорта");
            }
            if (regStatus == 2)
            {
                Console.WriteLine("Введите номер билета: ");
                passenger.Ticket = int.Parse(Console.ReadLine());
                Random rnd = new Random();
                passenger.Pasport = $"{(char)rnd.Next('A', 'Z' + 1)}{(char)rnd.Next('A', 'Z' + 1)}{rnd.Next(100000,999999)} ";
                passenger.Gate = rnd.Next(1, 20);
                Console.WriteLine("Вы путешествуете с багажом? \n1. да \n2. нет");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Поставте багаж на весы");                        
                        luggage.Luggag();
                        Console.WriteLine($"проходите к выходу {passenger.Gate}");
                        break;
                    case 2:
                        Console.WriteLine($"проходите к выходу {passenger.Gate}");
                        break;
                    default:
                        Console.WriteLine("да(1) или нет(2)");
                        break;
                }
            }
        }
    }
}
