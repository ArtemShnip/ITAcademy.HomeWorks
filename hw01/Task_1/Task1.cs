using System;

namespace Task_1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a poem in one line, separating lines \';\': ");
            string poem = " Two roads diverged in a yellow wood,; And sorry I could not travel both; And be one traveler, long I stood; And looked down one as far as I could; To where it bent in the undergrowth.";
            Console.WriteLine("\n\noutput:\n" + poem);
            string[] poemLines = poem.Split(new char[] {';'});
            Console.WriteLine("\n\n");
            for (int i = 0; i < poemLines.Length; i++)
            {
                poemLines[i] = poemLines[i].ToUpper().Replace('O', 'A');
                Console.WriteLine(poemLines[i]);
            }
        }
    }
}
