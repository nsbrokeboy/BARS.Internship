using System;

namespace BARS.Internship.Task6.MyCustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyCustomException("кастомное исключение");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}