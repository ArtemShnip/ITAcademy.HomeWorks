using System;
using System.Diagnostics;

namespace Task4_2
{
    class Task4_2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press to start");
            Console.ReadLine();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Int64[] array = new Int64[100000000];
            for (Int64 i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next();
            }
            
            Array.Reverse(array);

            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            Console.WriteLine(timeSpan);

        }
    }
}
