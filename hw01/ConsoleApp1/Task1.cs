using System;

namespace ConsoleApp1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("      array random");
            int[] arrayRandom = new int[10];
            for (int i = 0; i < arrayRandom.Length; i++)
            {
                arrayRandom[i] = new Random().Next(1, 10);
                Console.WriteLine("index " + i + " - " + "element " + arrayRandom[i]);
            }

            Console.WriteLine();
            Console.WriteLine("      array user");
            Console.WriteLine("fill the array");
            int[] arrayUser = new int[10];
            for (int i = 0; i < arrayUser.Length; i++)
            {                
                arrayUser[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("index " + i + " - " + "element " + arrayUser[i]);
            }

            Console.WriteLine();
            Console.WriteLine("      array sum");
            int[] arraySum = new int[10];
            for (int i = 0; i < arraySum.Length; i++)
            {
                arraySum[i] = arrayRandom[i] + arrayUser[i];
                Console.WriteLine("index " + i + " - " + "element " + arraySum[i]);
            }
        }
    }
}
