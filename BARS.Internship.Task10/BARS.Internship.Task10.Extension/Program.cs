
using System;

namespace BARS.Internship.Task10.Exstension
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "азбука";
            Console.WriteLine(str.CharCount('а'));
        }
    }

    internal static class StringExtension
    {
        public static int CharCount(this string input, char c)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == c)
                {
                    count++;
                }
            }

            return count;
        }
    }
}