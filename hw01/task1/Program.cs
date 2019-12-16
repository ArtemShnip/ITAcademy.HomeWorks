using System;

namespace HW04._1_Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            char bletter;
            char sletter;
            for (int i = 90,j=122 ; i > 64; i--, j--)       
            {
                Bletter = Convert.ToChar(i);
                Sletter = Convert.ToChar(j);
                Console.WriteLine(Bletter + " " + Sletter);     
            }
        }
    }
}
