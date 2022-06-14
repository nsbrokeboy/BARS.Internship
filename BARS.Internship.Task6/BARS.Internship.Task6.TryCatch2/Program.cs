using System;

namespace BARS.Internship.Task6.TryCatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            try
            {
                throw new ArgumentException();
            }
            catch
            {
                Console.WriteLine("Что-то случилось");
            }

            // 2
            try
            {
                throw new ArgumentException("blahblah");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Что-то случилось, а именно: {e.Message}");
            }
            
            // 3
            try
            {
                throw new ArgumentException("игнорируется");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"Что-то случилось, а именно: {e.Message}");
            }
        }
    }
}