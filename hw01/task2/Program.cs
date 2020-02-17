using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("нажмите клавишу, для выхода нажмите'q'" );
            Found:
            string selection = Console.ReadLine();
                switch (selection){
                case "W":
                case "w":
                    Console.WriteLine("Вверх");
                    goto Found;
                case "S":
                case "s":
                    Console.WriteLine("Вниз");
                    goto Found;
                case "A":
                case "a":
                    Console.WriteLine("Влево");
                    goto Found;
                case "D":
                case "d":
                    Console.WriteLine("Вправо");
                    goto Found;
                case "Q":
                case "q":
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную клавишу");
                    goto Found;
                }
            Console.WriteLine("Вы вышли");
        }
    }
}
