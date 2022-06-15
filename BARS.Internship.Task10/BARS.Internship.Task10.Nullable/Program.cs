using System;

namespace BARS.Internship.Task10.Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // явное преобразование от T? к T
            int? x1 = null;
            if(x1.HasValue)
            {
                int x2 = (int) x1;
                Console.WriteLine(x2);
            }
            
            // неявное преобразование от T к T?
            int y1 = 4;
            int? y2 = y1;
            Console.WriteLine(y2);
            
            // неявные расширяющие преобразования от V к T?
            int z1 = 4;
            long? z2 = x1;
            Console.WriteLine(z2);
            
            // явные сужающие преобразования от V к T?
            long a1 = 4;
            int? a2 = (int?)a1;
            
            // преобразования от V? к T?
            long? b1 = 4;
            int? b2 = (int?)b1;
            
            // явные преобразования от V? к T
            long? c1 = null;
            if (c1.HasValue) 
            { 
                int c2 = (int)c1; 
            }
        }
    }
}