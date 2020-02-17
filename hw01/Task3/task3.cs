using System;

namespace Task3
{
    class task3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lenght array - ");
            int lenghtArray = int.Parse(Console.ReadLine());
            Console.WriteLine("      array user");
            Console.WriteLine("fill the array");
            int[] arrayUser = new int[lenghtArray];
            for (int i = 0; i < arrayUser.Length; i++)
            {
                arrayUser[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("index " + i + " - " + "element " + arrayUser[i]);
            }
            Console.WriteLine();
            Console.WriteLine("To perfom the revers? \n press Y/N");
            string response = Console.ReadLine();
            if (response=="y"|| response == "Y")
            {
                for (int first = 0, last=arrayUser.Length-1; first < last; first++,last--)
                {
                    int elementFirst = arrayUser[first];
                    int elementLast = arrayUser[last];
                    arrayUser[first] = elementLast;
                    arrayUser[last] = elementFirst;
                }

            }
                for (int i = 0; i < arrayUser.Length; i++)
                {
                    Console.WriteLine("index " + i + " - " + "element " + arrayUser[i]);
                }
        }

    }
}
