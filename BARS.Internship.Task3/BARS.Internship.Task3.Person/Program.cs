using System;

namespace BARS.Internship.Task3.Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    class Person
    {
        // private поле недоступно в наследнике, только в рамках своего класса, необходимо использовать protected или private protected, например 
        protected string _name;
 
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee : Person
    {
        public int Age { get; set; }

        public Employee(string name, int age) : base(name)
        {
            Age = age;
        }
        
        public Employee(string name) : base(name)
        {
        }
        
        public void Display()
        {
            Console.WriteLine(_name);
        }

        
    }

}