using System;

namespace BARS.Internship.Task8.SomeDel
{
    delegate void SomeDel(int a, double b);

    delegate T GenericDelegate<T, K>(K val);

    class Program
    {
        static void Main(string[] args)
        {
            // подходит только первый, т.к. имеет одинаковую сигнатуру с делегатом
            var someDelegate = new SomeDel(SomeMethod1);
            someDelegate += MyMethod;
            
            var anotherDelegate = new SomeDel(someDelegate);
            anotherDelegate += MyMethod;

            var coupleOfDelegates = new SomeDel(someDelegate);
            coupleOfDelegates += anotherDelegate;

            if (coupleOfDelegates != null)
            {
                coupleOfDelegates(1, 4);
            }
           
            Console.WriteLine("-------------------");
            // invoke позволяет использовать условный оператор '?' и для рефлексии -_-
            // Ещё метод Invoke позволяет преодолеть основной недостаток делегатов:
            // несовместимость делегатов разных типов, но одной сигнатуры, по присваиванию.
            coupleOfDelegates?.Invoke(3, 5.5);
            Console.WriteLine("-------------------");
            // 3 так как состоит из двух делегатов и 1 метода, но выполняется 5 методов 
            DoSomething(coupleOfDelegates);

            Console.WriteLine("----------");
            GenericDelegate<string, int> genericDelegate = MethodForGeneric;
            Console.WriteLine(genericDelegate?.Invoke(5));
        }

        static void SomeMethod1(int g, double n) {
            Console.WriteLine("Some method 1 invoked!");
        }

        static void MyMethod(int x, double y)
        {
            Console.WriteLine("My method invoked!");
        }
        // int SomeMethod2(int g, double n) { return 0;}
        // void SomeMethod3(double n, int g) { }
        // static void SomeMethod4(ref int g, double n) { }
        // static void SomeMethod5(out int g, double n) { g = 6; }

        static void DoSomething(SomeDel del)
        {
            if (del is not null)
                Console.WriteLine(del.GetInvocationList().Length);
        }
        
        static string MethodForGeneric(int x) => x.ToString() + " " + x.ToString(); 
    }
}
