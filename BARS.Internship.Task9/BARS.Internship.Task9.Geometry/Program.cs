using System;
using System.Threading.Channels;

namespace BARS.Internship.Task9.Geometry
{
    delegate double Calculate(double param);
    
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            
            try
            {
                radius = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            Calculate calculate = Circle.Length;
            Console.WriteLine(calculate.Invoke(radius));
            
            calculate = Circle.Area;
            Console.WriteLine(calculate.Invoke(radius));

            calculate = Circle.Volume;
            Console.WriteLine(calculate.Invoke(radius));
        }
    }
}