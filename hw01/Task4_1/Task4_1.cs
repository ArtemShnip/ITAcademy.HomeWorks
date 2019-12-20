using System;
using System.Diagnostics;

namespace Task4_1
{
    class Task4_1
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
            for (Int64 first = 0, last = array.Length - 1; first < last; first++, last--)
            {
                Int64 elementFirst = array[first];
                Int64 elementLast = array[last];
                array[first] = elementLast;
                array[last] = elementFirst;
            }
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            Console.WriteLine(timeSpan);

        }
    }
}
