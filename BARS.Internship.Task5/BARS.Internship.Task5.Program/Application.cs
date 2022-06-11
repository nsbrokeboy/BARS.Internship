using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BARS.Internship.Task5.CompanyStructure;

namespace BARS.Internship.Task5.Program
{
    public class Application
    {
        private List<Company> _companies;

        public Application()
        {
            _companies = new List<Company>();
            
            var employees = new List<Employee>(new []
            {
                new Employee("Марков Роман", new DateTime(2000, 05, 15), 50000),
                new Employee("Носов Олег", new DateTime(1997, 11, 2), 43000),
                new Employee("Зиновьев Филипп", new DateTime(2002, 1, 27), 77000),
                new Employee("Емельянов Максим", new DateTime(1995, 9, 30), 77000),
            });
            
            _companies.Add(new Company("1Компания1", "Ну чет какая то компания чем то таким занимается", employees));
            _companies.Add(new Company("2Компания2", "Другая", employees));
            _companies.Add(new Company("3Компания3", "Еще одна", employees));
            _companies.Add(new Company("4Компания4", "Последняя", employees));
        }

        public void MainMenu()
        {
            while (true)
            {
                Console.Write("Выберите действие:\n1. Посмотреть информацию о компаниях:\n0. Выход\n> ");
                switch (Console.ReadLine())
                {
                    case "1":
                        CompaniesMenu();
                        Console.WriteLine();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверная команда");
                        Console.WriteLine();
                        break;
                }
            }
        }

        public void CompaniesMenu()
        {
            Company selectedCompany;
            Console.WriteLine("Список компаний:");
            int index = 1;
            foreach (var company in _companies)
            {
                Console.WriteLine($"{index}. {company.Name}");
                index++;
            }

            while (true)
            {
                Console.WriteLine();
                Console.Write("Введите номер компании, чтобы узнать подробности. Для выхода введите 0:\n> ");
                int companyIndex = Convert.ToInt32(Console.ReadLine());
                if (companyIndex == 0)
                {
                    return;
                }
                if (companyIndex <= _companies.Count)
                {
                    selectedCompany = _companies.ElementAt(companyIndex - 1);
                    var employees = selectedCompany.Employees;
                    Console.WriteLine($"Название: {selectedCompany.Name}\nОписание: {selectedCompany.Description}\n");
                    Console.WriteLine("Выберите действие:\n1. Список сотрудников компании\n2. Назад\n0. В главное меню");
                    var inputCommand = Console.ReadLine();
                    if (inputCommand == "0")
                    {
                        return;
                    }
                    
                    if (inputCommand == "1")
                    {
                        EmployeesMenu(employees);
                    }
                    else if (inputCommand == "2")
                    {
                    }
                    else
                    {
                        Console.WriteLine("\nНеверная команда\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nНеверная команда\n");
                }
            }
        }

        public void EmployeesMenu(IList<Employee> employees)
        {
            Console.WriteLine("\nСписок сотрудников компании");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employees.IndexOf(employee) + 1}. {employee.FullName}");
            }

            Console.Write("\nВведите номер сотрудника, чтобы узнать подробности. Для выхода введите 0:\n> ");
            int indexEmployee = Convert.ToInt32(Console.ReadLine());
            if (indexEmployee == 0)
            {
                return;
            }
            if (indexEmployee <= employees.Count)
            {
                var selectedEmployee = employees.ElementAt(indexEmployee - 1);
                Console.WriteLine();
                Console.WriteLine(
                    @$"Работник: {selectedEmployee.FullName}
Дата рождения: {selectedEmployee.DateOfBirthday.Day}.{selectedEmployee.DateOfBirthday.Month}.{selectedEmployee.DateOfBirthday.Year}
Заработная плата: {selectedEmployee.Salary} руб.");
                
                Console.WriteLine("\nВыберите действие:\n1. Изменить фамилию и имя\n2. Изменить дату рождения\n3. Изменить ЗП\n0. Выход");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Введите фамилию и имя:");
                        var name = Console.ReadLine();
                        selectedEmployee.EditFullName(name);
                        Console.WriteLine("Готово");
                        break;
                    case "2":
                        Console.Write("Введите день: ");
                        var day = Convert.ToInt32(Console.ReadLine());
                        
                        Console.Write("Введите месяц: ");
                        var month = Convert.ToInt32(Console.ReadLine());
                        
                        Console.Write("Введите год: ");
                        var year = Convert.ToInt32(Console.ReadLine());

                        selectedEmployee.EditDateOfBirthday(day, month, year);
                        Console.WriteLine("Готово");
                        break;
                    case "3":
                        Console.Write("Введите новое значение ЗП: ");
                        var salary = Convert.ToInt32(Console.ReadLine());
                        
                        selectedEmployee.EditSalary(salary);
                        Console.WriteLine("Готово");
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда");
                        break;
                }
            }
            
        }
    }
}