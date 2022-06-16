using System;
using System.Threading;

namespace BARS.Internship.Task11.Gardener
{
    class Program
    {
        static int m = 10, n = 10;
        static int[,] garden = new int[m, n];


        static void Main(string[] args)
        {
            var firstThreadStart = new ParameterizedThreadStart(DoGardenThingsFirst);
            var secondThreadStart = new ParameterizedThreadStart(DoGardenThingsSecond);

            var firstGardener = new Thread(firstThreadStart);
            var secondGardener = new Thread(secondThreadStart);
            firstGardener.Start(garden);
            secondGardener.Start(garden);

            firstGardener.Join();
            secondGardener.Join();
            
            PrintGarden();

        }

        static void DoGardenThingsFirst(object? obj)
        {
            if (obj is int[,] garden)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (garden[i, j] == 0)
                        {
                            garden[i, j] = 1;
                        }
                        Thread.Sleep(1);
                    }
                }
            }
        }
        
        static void DoGardenThingsSecond(object? obj)
        {
            if (obj is int[,] garden)
            {
                for (int j = m - 1; j > 0 ; j--)
                {
                    for (int i = n - 1; i > 0; i--)
                    {
                        if (garden[i, j] == 0)
                        {
                            garden[i, j] = 2;
                        }
                        
                        Thread.Sleep(1);
                    }
                }
            }
        }

        static void PrintGarden()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}