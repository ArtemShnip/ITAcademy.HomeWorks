using System;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("enter lenght array - ");
            int lenghtArray = int.Parse(Console.ReadLine());
            Console.WriteLine("      array user");
            Console.WriteLine("fill the array");
            int[] arrayUser = new int[lenghtArray];
            for (int i = 0; i < arrayUser.Length-1; i++)
            {
                arrayUser[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("index " + i + " - " + "element " + arrayUser[i]);
            }

            Console.WriteLine();
            Console.WriteLine("enter element");
            Console.Write("element - ");            
            int element = int.Parse(Console.ReadLine());
            Console.Write("position - ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = arrayUser.Length - 1; i >= position; i--)
            {
                arrayUser[i] = arrayUser[i - 1];
            }
            arrayUser[position] = element;

            for (int i = 0; i < arrayUser.Length; i++)
            {
                Console.WriteLine("index " + i + " - " + "element " + arrayUser[i]);
            }
        }
    }
}
