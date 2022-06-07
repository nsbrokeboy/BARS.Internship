using System;

namespace BARS.Internship.Task2.Person
{
    public class Person
    {
        private string name;
        public string Name
        {
            set
            {
                name = "Имя";
            }

            get
            {
                return name;
            }
        }


        private int age;
        public int Age {
            get
            {
                return age;
            }
            private set
            {
                age = value;
            } 
        }

        public DateTime DateOfBirthday { get; set; }

        private string address;

        public string Address
        {
            get => address;
            set => address = value;
        }
    }
}