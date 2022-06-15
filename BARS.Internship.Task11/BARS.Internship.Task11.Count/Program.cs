using System;
using System.Threading;

namespace BARS.Internship.Task11.Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var threadStart = new ThreadStart(Count);
            var thread = new Thread(threadStart);
            thread.Start();
            
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"Главный поток {i * i}");
                Thread.Sleep(300);
            }
        }

        static void Count()
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"Второй поток {i * i}");
                Thread.Sleep(400);
            }
        }
    }
}