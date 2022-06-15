using System;
using System.Threading;

namespace BARS.Internship.Task11.ParameterizedCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var threadStart = new ParameterizedThreadStart(Count);
            var thread = new Thread(threadStart);
            thread.Start(9);
            
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"Главный поток {i * i}");
                Thread.Sleep(300);
            }
        }
        
        static void Count(object? obj)
        {
            if (obj is int x)
            {
                for (int i = 1; i <= x; i++)
                {
                    Console.WriteLine($"Второй поток {i * i}");
                    Thread.Sleep(400);
                }   
            }
        }
    }
}