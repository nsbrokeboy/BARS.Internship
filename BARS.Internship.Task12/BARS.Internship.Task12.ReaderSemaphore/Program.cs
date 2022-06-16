using System;

namespace BARS.Internship.Task12.ReaderSemaphore
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                var reader = new Reader(i);
            }
        }
    }
}