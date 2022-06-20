using System;
using System.Threading;

namespace BARS.Internship.Task12.WriterReader
{
    public class Transaction : IDisposable
    {
        private static int x = 0;
        
        private readonly ReaderWriterLockSlim _rwLock = 
            new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion);

        private DateTime _dateTime = new DateTime();

        public void PerformTransaction()
        {
            _rwLock.EnterWriteLock();
            x += 1;
            Console.WriteLine($"Транзакция выполняется ({x})");
            _dateTime = DateTime.Now;
            
            _rwLock.ExitWriteLock();
        }

        public DateTime LastTransaction()
        {
            _rwLock.EnterReadLock();
            x -= 1;
            DateTime last = _dateTime;
            Console.WriteLine($"Последняя транзакиця ({x}): {last.ToString()}");
            
            _rwLock.ExitReadLock();
            
            return last;
        }

        public void Dispose()
        {
            _rwLock.Dispose();
        }
    }
}