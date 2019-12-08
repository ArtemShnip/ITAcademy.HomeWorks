using System;

namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte Sb1 = 1;
            SByte Sb2 = 2;

            short Sh1 = 3;
            Int16 Sh2 = 4;

            int In1 = 5;
            Int32 In2 = 6;

            long Lo1 = 7;
            Int64 Lo2 = 8;

            byte By1 = 9;
            Byte By2 = 10;

            ushort uSh1 = 11;
            UInt16 uSh2 = 12;

            char Ch1 = 'q';
            Char Ch2 = 'w';

            uint uIn1 = 13;
            UInt32 uIn2 = 14;

            ulong uLo1 = 15;
            UInt64 uLo2 = 16;

            float Fl1 = 17.01f;
            Single Fl2 = 18.12f;

            double Do1 = 19.03;
            Double Do2 = 20.24;

            decimal Dc1 = 21.22m;
            Decimal Dc2 = 22.34m;

            object Obj1 = "qqq";
            Object Obj2 = "111";

            string str1 = "www";
            String str2 = "222";

            object[] array = new object[] { Sb1, Sb2, Sh1, Sh2, In1, In2, Lo1, Lo2, By1, By2, uSh1, uSh2, Ch1, Sh2, uIn1, uIn2, uLo1, uLo2, Fl1, Fl2, Do1, Do2, Dc1, Dc2, Obj1, Obj2, str1, str2 };
            foreach (object types in array)
            {
                Console.WriteLine(types.GetType());
            }
        }
    }
}
