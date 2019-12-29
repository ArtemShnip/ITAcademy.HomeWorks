using System;

namespace Task_2
{
    class Task2
    {
        static void Main(string[] args)
        {
            string poem = "Two roads diverged in a yellow wood, And sorry I could not travel both";
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
            Item2(maxIndex, minIndex, words);
            Item3(words);
            Item4(words);
            Console.ReadLine();
        }
        static void Item1(int maxIndex,string[] words)
        {
            Console.WriteLine("\ntask1:");
            string[] wordsItem1 = (string[])words.Clone();
            Array.Clear(wordsItem1, maxIndex, 1);
            String output = String.Join(" ", wordsItem1);
            Console.WriteLine(output);
        }
        static void Item2(int maxIndex,int minIndex, string[] words)
        {
            Console.WriteLine("\ntask2:");
            string[] wordsItem2 = (string[])words.Clone();
            string temporary = wordsItem2[minIndex];
            wordsItem2[minIndex] = wordsItem2[maxIndex];
            wordsItem2[maxIndex] = temporary;
            String output = String.Join(" ", wordsItem2);
            Console.WriteLine(output);
        }
        static void Item3(string[] words)
        {
            Console.WriteLine("\ntask3:");
            string[] wordsItem3 = (string[])words.Clone();
            char[] signs = new char[10] { '.', ',', ';', ';', '?', '!', '-', '(', ')', '\"' };
            int countSigns = 0;
            int countLeters = 0;
            for (int i = 0; i < wordsItem3.Length; i++)
            {
                for (int j = 0; j < wordsItem3[i].Length; j++)
                {
                    if (wordsItem3[i].Contains(signs[j]))
                    {
                        countSigns++;
                    }
                    else
                    {
                        countLeters++;
                    }
                }
            }
            Console.WriteLine("leters: " + countLeters + " \nsigns: " + countSigns);
        }
        static void Item4(string[] words)
        {
            Console.WriteLine("\ntask4:");
            string[] wordsItem3 = (string[])words.Clone();
            string temporary;
            for (int i = 0; i < wordsItem3.Length - 1; i++)
            {
                for (int j = i + 1; j < wordsItem3.Length; j++)
                {
                    if (wordsItem3[i].Length < wordsItem3[j].Length)
                    {
                        temporary = wordsItem3[i];
                        wordsItem3[i] = wordsItem3[j];
                        wordsItem3[j] = temporary;
                    }
                }
            }
            for (int i = 0; i < wordsItem3.Length; i++)
            {
                Console.WriteLine(wordsItem3[i]);
            }
        }
    }
}
