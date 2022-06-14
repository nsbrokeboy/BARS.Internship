using System;

namespace BARS.Internship.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Convert.ToInt32(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());
            decimal result = 0;
            try
            {
                // if (y == 0)
                // {

                // // на самом деле можно бы было и не выкидывать вручную т.к. в блоке try-catch
                // throw new DivideByZeroException("На ноль делить нельзя!");
                // }

                result = (decimal)x / y;
            }
            catch (DivideByZeroException e) when (y == 0)
            {
                Console.WriteLine("y не должен быть равен 0");
            }
            catch (Exception e)
            {
                Console.WriteLine("случилось что-то другое");
            }
            finally
            {
                Console.WriteLine(result);
            }
        }
    }
}