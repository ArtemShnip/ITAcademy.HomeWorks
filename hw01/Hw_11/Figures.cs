using System;
namespace Hw_11
{
    class Figures
    {
        public int Side { get; set; }

        public string Type { get; set; }

        public double Area { get; set; }

        public override string ToString()
        {
            return $"This is {Type}. CLRType is {Type}. Area is {Area} ";
        }
    }
}
