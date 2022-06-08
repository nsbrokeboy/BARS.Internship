using System;

namespace BARS.Internship.Task4.New
{
    class Program
    {
        static void Main(string[] args)
        {
            var parent = new Person();
            var child = new Employee();

            Console.WriteLine(parent.Name);
            Console.WriteLine(child.Name);
        }
    }
}