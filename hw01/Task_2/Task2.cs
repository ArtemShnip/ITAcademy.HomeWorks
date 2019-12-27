using System;

namespace Task_2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string poem = "Two roads diverged in a yellow wood And sorry I could not travel both";
            Console.WriteLine("main:\n" + poem);
            string[] words = poem.Split(' ');
            int maxLength = 0;
            int maxIndex = 0;
            int minLength = 1000;
            int minIndex = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                    maxIndex = i;
                }
                if (words[i].Length < minLength)
                {
                    minLength = words[i].Length;
                    minIndex = i;
                }
            }
            Item1(maxIndex, words);
            Item2(maxIndex, maxLength, minIndex, minLength, words);
            Console.ReadLine();
        }
        static void Item1(int maxIndex,string[] words)
        {
            string[] wordsItem1 = (string[])words.Clone();
            Console.WriteLine("\ntask1:");
           Array.Clear(wordsItem1, maxIndex, 1);
            String output = String.Join(" ", wordsItem1);
            Console.WriteLine(output);
        }
        static void Item2(int maxIndex,int maxLength,int minIndex,int minLength, string[] words)
        {
            string[] wordsItem2 = words;
            Console.WriteLine("\ntask2:");
            string temporary = wordsItem2[minIndex];
            wordsItem2[minIndex] = wordsItem2[maxIndex];
            wordsItem2[maxIndex] = temporary;
            String output = String.Join(" ", wordsItem2);
            Console.WriteLine(output);
        }
    }
}
