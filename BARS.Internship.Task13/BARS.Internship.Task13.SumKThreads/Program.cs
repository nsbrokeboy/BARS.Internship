using System;
using System.Threading;
using System.Threading.Channels;

namespace BARS.Internship.Task13.SumKThreads
{
    class Program
    {
        // int sum = mas.AsParallel().Sum(); ¯\_(ツ)_/¯

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

            Console.WriteLine("Введите количество потоков:");
            
            int k = Convert.ToInt32(Console.ReadLine());

            var information = new Information(array, 0, k, n / k);
            for (int i = 0; i < k; i++)
            {
                var thread = new Thread(CountSum);
                thread.Start(information);
                information.counter++;
            }

            for (int i = 0; i < information.countOfThreads; i++)
            {
                sum += information.partialSums[i];
            }
        }

        static void CountSum(object obj)
        {
            var information = obj as Information;
            int localSum = 0;
            
            for (int i = information.counter * information.countOfThreads;
                 i < (information.counter + 1) * information.countOfThreads;
                 i++)
            {
                localSum += information.array[i];
            }

            information.partialSums[information.counter] += localSum;
            // information.counter++; -- перенести в фор где запуск
        }
    }

    class Information
    {
        public int[] array;
        public int counter;
        public int countOfThreads;
        public int arraySizeInThread;
        public int[] partialSums;
        
        public Information(int[] array, int counter, int countOfThreads, int arraySizeInThread)
        {
            this.array = array;
            this.counter = counter;
            this.countOfThreads = countOfThreads;
            this.arraySizeInThread = arraySizeInThread;
            partialSums = new int[countOfThreads];
        }
    }
}