using System;
 
namespace BARS.Internship.Task5.CompanyStructure
{
    public class Employee
    {
        public string FullName { get; private set; }

        public DateTime DateOfBirthday { get; private set; }

        public int Salary { get; private set; }

        public Employee(string fullName, DateTime dateOfBirthday, int salary)
        {
            FullName = fullName;
            DateOfBirthday = dateOfBirthday;
            Salary = salary;
        }

        public void EditFullName(string name)
        {
            FullName = name;
        }

        public void EditDateOfBirthday(int day, int month, int year)
        {
            var newDate = new DateTime(year, month, day);
            DateOfBirthday = newDate;
        }

        public void EditSalary(int salary)
        {
            Salary = salary;
        }
    }
}