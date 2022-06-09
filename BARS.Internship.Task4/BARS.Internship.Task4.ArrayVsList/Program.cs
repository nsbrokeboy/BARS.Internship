using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace BARS.Internship.Task4.ArrayVsList
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            var list = new List<int>();

            Stopwatch stopwatch = new Stopwatch();
            
            stopwatch.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                arrayList.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"Время добавления для ArrayList: {stopwatch.ElapsedMilliseconds} мс");
            
            stopwatch.Reset();
            
            stopwatch.Start();
            for (int i = 1; i <= 1000000; i++)
            {
                list.Add(i);
            }
            stopwatch.Stop();
            Console.WriteLine($"Время добавления для List: {stopwatch.ElapsedMilliseconds} мс");
            
            // быстрее list ведь это generic-коллекция которая и может принимать в себя в данном случае инты,
            // а в arrayList происходит boxing => производительность страдает, т.к. он содержит в себе object-ы
        }
    }
}