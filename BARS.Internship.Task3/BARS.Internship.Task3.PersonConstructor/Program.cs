using System;

namespace BARS.Internship.Task3.PersonConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // upcasting
            Person person = new Employee("qwe","zxc");
            object human = person;
            
            // downcasting
            Employee employee = (Employee)person;

            // use 'as'
            var casting = new Person("zasdas") as Employee;
        }
    }
    
    // класс -> родитель -> Object
        
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Person {Name}");
        }
    }
 
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
        }
    }
 
    class Client : Person
    {
        public string Bank { get; set; }
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }
    }

}