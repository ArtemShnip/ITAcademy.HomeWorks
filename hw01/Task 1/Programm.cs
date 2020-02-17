using System;

namespace Hw_10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("        Task 1\n");
            Random draftRnd = new Random();
            Random CrewRnd = new Random();
            int draft = draftRnd.Next(1,100);
            int crew = CrewRnd.Next(1,100);
            Ship ship = new Ship(draft, crew);
            Console.WriteLine(ship.IsWorthIt());
            Console.ReadLine();

            Console.WriteLine("        Task 2\n");
            Person john = new Person("john", 34);
            Console.WriteLine($"{ john.Info}");
            Console.ReadLine();

            Console.WriteLine("        Task 3\n");
            Ball ball1 = new Ball();
            Console.WriteLine($"{ball1.ballType}");
            Ball ball2 = new Ball("super");
            Console.WriteLine($"{ball2.ballType}");
            Console.ReadLine();

            Console.WriteLine("        Task 4\n");
            Block block = new Block(new int[] { 2, 4, 6 });
            Console.WriteLine($"{block.GetHeight()}\n{block.GetLength()}\n{block.GetWidth()}\n{block.GetVolume()}\n{block.GetSurfaceArea()}");
            Console.ReadLine();

            Console.WriteLine("        Task 5\n");
            int[] _integerList = new int[] { 1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8 };
            int[] _valuesList = new int[] { 1, 3, 4, 2 };
            int[] resultArray = Kata.Remove(_integerList, _valuesList);

            foreach (int i in resultArray)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
