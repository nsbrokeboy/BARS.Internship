using System;
using System.Threading;

namespace BARS.Internship.Task12.WriterReader
{
    class Program
    {
        static ReaderWriterLockSlim rwLock = new ReaderWriterLockSlim();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Read(int i)
        {
            // ? 
            rwLock.EnterWriteLock();
            Console.WriteLine($"{i} Читаю");
            rwLock.ExitWriteLock();
        }

        static void Write(int i)
        {
            rwLock.EnterReadLock();
            rwLock.EnterWriteLock();
            Console.WriteLine($"{i} пишу");
            rwLock.ExitWriteLock();
            rwLock.ExitReadLock();
        }
    }
}