using System;
using System.Threading;

namespace BARS.Internship.Task12.Timer
{
    class Program
    {
        public static int x;

        static Program()
        {
            x = 0;
        }

        static void Main(string[] args)
        {
            var timerCallback = new TimerCallback(PrintWeather);
            var timer = new System.Threading.Timer(timerCallback, null, 0, 10000);
            Console.ReadLine();
        }

        static void PrintWeather(object? obj)
        {
            if (x < 2)
            {
                Console.WriteLine("Идет дождь");
            }
            else
            {
                Console.WriteLine("Солнечно");
            }

            x++;
        }
    }
}