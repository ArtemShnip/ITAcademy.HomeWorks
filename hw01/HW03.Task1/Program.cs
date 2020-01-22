using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            byte numByte = 8;
            int numInt = numByte;
            ushort numUs = 16;
            long numLong = numUs;
            uint numUi = 32;
            decimal numDec = numUi;

            //explicit conversion
            long numL2 = 3576;
            uint numUi2 = (uint)numL2 + 22;
            double numI2 = 123.09;
            float numFl2 = (float)numI2 + 33.09f;
            float numF2 = 234;
            uint numU2 = (uint)numF2 + 54;

            //boxing
            object o1 = numL2;
            object o2 = numUs;
            object o3 = numFl2;

            //unboxing
            long unb1 = (long)o1;
            ushort unb2 = (ushort)o2;
            float unb3 = (float)o3;
        }
    }
}
