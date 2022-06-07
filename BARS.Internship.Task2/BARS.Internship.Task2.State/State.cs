using System;

namespace BARS.Internship.Task2.State
{
    // internal
    class State
    {
        // private
        string name;

        int defaultVar;
        
        private int privateVar;
        
        protected int protectedVar;
        
        internal int internalVar;
        
        protected internal int protectedInternalVar;

        public int publicVar;
        
        // private
        void Print()
        {
            Console.WriteLine(name);
        }
        
        void defaultMethod() => Console.WriteLine($"defaultVar = {defaultVar}");
 
        private void privateMethod() => Console.WriteLine($"privateVar = {privateVar}");
 
        protected void protectedMethod()=> Console.WriteLine($"protectedVar = {protectedVar}");
     
        internal void internalMethod() => Console.WriteLine($"internalVar = {internalVar}");
     
        protected internal void protectedInternalMethod() => Console.WriteLine($"protectedInternalVar = {protectedInternalVar}");
     
        public void publicMethod() => Console.WriteLine($"publicVar = {publicVar}");
        
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Result is {result}");
        }

        // Нельзя создать несколько методов с одинаковой сигнатурой
        
        // public void Add(int a1, int b1)
        // {
        //     int result = a + b;
        //     Console.WriteLine($"Result is {result}");
        // }

    }
}