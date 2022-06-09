using System;
using System.Threading.Channels;

namespace BARS.Internship.Task4.MyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray<string> myArrayStrings = new MyArray<string>(5);

            for (int i = 0; i < 10; i++)
            {
                myArrayStrings.Add(i.ToString() + "qweqwe");
            }

            Console.WriteLine(myArrayStrings.ToString());
            Console.WriteLine(myArrayStrings.Length);
            Console.WriteLine();
            
            myArrayStrings.DeleteByIndex(7);
            Console.WriteLine(myArrayStrings.ToString());
            Console.WriteLine(myArrayStrings.Length);
            Console.WriteLine();

            Console.WriteLine(myArrayStrings.GetByIndex(8));
        }
    }
}