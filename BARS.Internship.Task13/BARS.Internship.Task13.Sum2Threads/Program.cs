using System;
using System.Threading;

namespace BARS.Internship.Task13.Sum2Threads
{
    class Program
    {
        private static int sum = 0;
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Введите числа по порядку:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            var threadFirst = new Thread(CountFirstHalf);
            var threadSecond = new Thread(CountSecondHalf);
            threadFirst.Start(array);
            threadSecond.Start(array);
            
            Thread.Sleep(10);
            
            Console.WriteLine($"Сумма: {sum} ");
        }

        static void CountFirstHalf(object obj)
        {
            var array = obj as int[];

            for (int i = 0; i < array.Length / 2; i++)
            {
                sum += array[i];
            }
        }
        
        static void CountSecondHalf(object obj)
        {
            var array = obj as int[];

            for (int i = array.Length / 2; i < array.Length; i++)
            {
                sum += array[i];
            }
        }
    }
}