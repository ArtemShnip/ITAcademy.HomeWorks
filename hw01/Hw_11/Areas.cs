using System;

namespace Hw_11
{
    class Areas :Figures
    {
        public double AreaSquare(int side)
        {
            double area = side * side;
            return area;
        }
        public double AreaCircle(int radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public double AreaTriangle(int side)
        {
            double area = (side * side) / 2;
            return area;
        }
    }
}
