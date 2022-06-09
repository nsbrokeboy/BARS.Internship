using System;

namespace BARS.Internship.Task4.Account
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var account1 = new Account<int>(1);
            Account<int>.Password = default;

            var account2 = new Account<string>("some guid");
            Account<string>.Password = "qwer";

            Console.WriteLine($"{account1.Id} - {Account<int>.Password}");
            Console.WriteLine($"{account2.Id} - {Account<string>.Password}");
        }
    }
}