using System;

namespace BARS.Internship.Task1.Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { name = "Tom", age=23 };
            ChangePerson(p);  
 
            Console.WriteLine(p.name);
            Console.WriteLine(p.age);
            Console.Read();
        }
 
        static void ChangePerson(Person person)
        {
            person.name = "Alice";
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name);
        }

        static void ChangePerson1(ref Person person)
        {
            person.name = "Alice";
            person = new Person { name = "Bill", age = 45 };
        }

        // ChangePerson1 нужен для передачи в него структуры (значимого типа), чтобы измененные значения полей сохранились,
        // а ChangePerson же нужен для работы с ссылочными типами, будь то класс, как это представлено в этом коде  
    }

    class Person
    {
        public string name;
        public int age;
    }

}