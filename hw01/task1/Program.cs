using System;

namespace HW04._1_Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            char bletter;
            char sletter;
            int unibl = 90;
            int unisl = 122;
            for (int i = 0; i < 26; i++)       
            {
                bletter = Convert.ToChar(unibl--);
                sletter = Convert.ToChar(unisl--);
                Console.WriteLine(bletter + " " + sletter);     
            }
        }
    }
}
