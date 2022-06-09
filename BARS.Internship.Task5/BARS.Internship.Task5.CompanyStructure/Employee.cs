using System;
 
namespace BARS.Internship.Task5.CompanyStructure
{
    public class Employee
    {
        private string FullName { get; set; }

        private DateTime DateOfBirthday { get; set; }

        private int Salary { get; set; }

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

        public void EditDateOfBirthday(DateTime date)
        {
            DateOfBirthday = date;
        }

        public void EditSalary(int salary)
        {
            Salary = salary;
        }
    }
}