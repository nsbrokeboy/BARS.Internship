using System;
using System.Threading;
using System.Threading.Channels;

namespace BARS.Internship.Task11.Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2)");
            var currentThread = Thread.CurrentThread;
            currentThread.Name = "Поток 1";
            
            Console.WriteLine($"Имя текущего потока: {currentThread.Name}");
            Console.WriteLine($"Запущен: {currentThread.IsAlive}");
            Console.WriteLine($"Приоритет: {currentThread.Priority}");
            Console.WriteLine($"Статус: {currentThread.ThreadState}");
            Console.WriteLine($"Домен приложения: {Thread.GetDomain()}");

            Console.WriteLine("\n-----------------------\n");
            
            Console.WriteLine("3)");
            var thread = new Thread(() => Console.WriteLine("Thread"));
            Console.WriteLine($"Состояние до запуска: {thread.ThreadState}");
            
            thread.Start();
            Console.WriteLine($"Состояние после запуска: {thread.ThreadState}");
            thread.Join();
            Console.WriteLine($"Состояние после остановки: {thread.ThreadState}");

            Console.WriteLine("\n-------------------------\n\n5)");
            var threadHighPriority =
                new Thread(new ThreadStart(() => Console.WriteLine("new thread with highest priority")))
                {
                    Priority = ThreadPriority.Highest
                };
            
            threadHighPriority.Start();
            Console.WriteLine(threadHighPriority.Priority);
            threadHighPriority.Join();
        }
    }
}