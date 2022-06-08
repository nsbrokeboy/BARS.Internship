using System;

namespace BARS.Internship.Task4.SealedMethod
{
    public class AnotherClass : ChildClass
    {
        // уже нельзя переопределить, ведь указан модификатор sealed
        // public override void HelloWorld() => Console.WriteLine("You can't override me xD");
    }
}