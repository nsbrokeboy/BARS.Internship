using System;
using System.Threading;

namespace BARS.Internship.Task12.MutexCount
{
    class Program
    {
        static Mutex _mutexObj = new();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var threadStart = new ThreadStart(CountMain);
            var thread = new Thread(threadStart);
            thread.Start();
            
            threadStart = new ThreadStart(Count);
            thread = new Thread(threadStart);
            thread.Start();
        }

        static void CountMain()
        {
            _mutexObj.WaitOne();
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"Главный поток {i * i}");
                Thread.Sleep(300);
            }
            _mutexObj.ReleaseMutex();
        }
        
        static void Count()
        {
            _mutexObj.WaitOne();
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"Второй поток {i * i}");
                Thread.Sleep(400);
            }

            _mutexObj.ReleaseMutex();
        }
    }
}