using System;

namespace BARS.Internship.Task4.SealedMethod
{
    public class ChildClass : SomeClass
    {
        public sealed override void HelloWorld()
        {
            base.HelloWorld();
            Console.WriteLine("I am a child class!");
        }
    }
}