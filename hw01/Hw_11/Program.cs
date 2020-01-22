using System;

namespace Hw_11
{
    class Program
    {
        [assembly: log4net.Config.XmlConfigurator(Watch = true)]
        static void Main(string[] args)
        {
           
            string[] names = new string[] { "square", "circle", "triangle" };
            Random rnd = new Random();
            object[] arrayFigur = new object[5];

            for (int i = 0; i < arrayFigur.Length; i++)
            {
                Figures figures = new Figures();
                figures.Side = rnd.Next(1, 10);
                figures.Type = names[rnd.Next(0, 2)];

                if (figures.Type.Equals("square"))
                {
                    Areas square = new Areas();
                    figures.Area = square.AreaSquare(figures.Side);
                }

                if (figures.Type.Equals("circle"))
                {
                    Areas circle = new Areas();
                    figures.Area = circle.AreaCircle(figures.Side);
                }

                if (figures.Type.Equals("triangle"))
                {
                    Areas triangle = new Areas();
                    figures.Area = triangle.AreaTriangle(figures.Side);
                }

                arrayFigur[i] = figures;
            }

            for (int i = 0; i < arrayFigur.Length; i++)
            {
                Console.WriteLine(arrayFigur[i]);
            }
        }
    }
}
