using System;

namespace Task_2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string poem = "Two roads diverged in a yellow wood And sorry I could not travel both";
            Console.WriteLine("main:\n" + poem);
            Item1(poem);
            Item2(poem);
            Console.ReadLine();
        }
        static void Item1(string poem)
        {
            Console.WriteLine("\ntask1:\n"+ poem);
            Console.WriteLine();
            string[] words = poem.Split(' ');
            int max = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max) max = words[i].Length;
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == max) Array.Clear(words, i, 1);
            }
            String output = String.Join(" ", words);
            Console.WriteLine(output);
        }
        static void Item2(string poem)
        {

        }
    }
}
