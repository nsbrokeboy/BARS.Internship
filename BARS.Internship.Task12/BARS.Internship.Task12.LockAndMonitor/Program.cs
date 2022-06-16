using System;
using System.Threading;

namespace BARS.Internship.Task12.LockAndMonitor
{
    class Program
    {
        private int _x = 0;

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        public void SomeMulththreadMethod(Action action)
        {
            object locker = new();

            try
            {
                Monitor.Enter(locker);
                
                action.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                Monitor.Exit(locker);
            }
        }
    }
    
    
    
}