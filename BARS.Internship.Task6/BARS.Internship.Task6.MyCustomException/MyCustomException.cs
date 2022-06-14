using System;

namespace BARS.Internship.Task6.MyCustomException
{
    public class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message)
        {
        }
    }
}