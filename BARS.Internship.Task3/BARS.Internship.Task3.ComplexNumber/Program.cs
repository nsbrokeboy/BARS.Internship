using System;

namespace BARS.Internship.Task3.ComplexNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.webmath.ru/poleznoe/formules_16_8.php
            
            var num1 = new ComplexNumber(5, -6);
            var num2 = new ComplexNumber(-3, 2);
            var result = num1 + num2;
            Console.WriteLine(result);

            num1 = new ComplexNumber(5, -6);
            num2 = new ComplexNumber(-3, 2);
            result = num1 - num2;
            Console.WriteLine(result);

            num1 = new ComplexNumber(2, 3);
            num2 = new ComplexNumber(-1, 1);
            result = num1 * num2;
            Console.WriteLine(result);
            
            num1 = new ComplexNumber(-2, 1);
            num2 = new ComplexNumber(1, -1);
            result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}