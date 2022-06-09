using System.Collections.Generic;

namespace BARS.Internship.Task5.CompanyStructure
{
    public class Company
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IList<Employee> Employees { get; set; }

        public Company(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public Company(string name, string description, IList<Employee> employees)
        {
            Name = name;
            Description = description;
            Employees = employees;
        }

        public void EditName(string name)
        {
            Name = name;
        }

        public void EditDescription(string description)
        {
            Description = description;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployeeByIndex(int index)
        {
            Employees.RemoveAt(index);
        }

        public void RemoveEmployeeByInstance(Employee employee)
        {
            Employees.Remove(employee);
        }
    }
}