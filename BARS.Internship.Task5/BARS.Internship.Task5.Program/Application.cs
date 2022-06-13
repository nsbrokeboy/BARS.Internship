using System;
using System.Collections.Generic;
using System.Linq;
using BARS.Internship.Task5.CompanyStructure;

namespace BARS.Internship.Task5.Program
{
    public class Application
    {
        private readonly List<Company> _companies;

        public Application()
        {
            _companies = new List<Company>();

            var employees = new List<Employee>(new[]
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

        private void CompaniesMenu()
        {
            while (true)
            {
                Console.WriteLine("Список компаний:");
                int index = 1;
                foreach (var company in _companies)
                {
                    Console.WriteLine($"{index}. {company.Name}");
                    index++;
                }

                Console.Write("Для просмотра компаний введите 1. Для добавления новой компании введите 2.\nДля выхода в главное меню введите 0:\n> ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine();
                        Console.Write(
                            "Введите номер компании, чтобы узнать подробности. Для выхода в главное меню введите 0:\n> ");
                        var companyIndex = Convert.ToInt32(Console.ReadLine());
                        if (companyIndex == 0)
                        {
                            return;
                        }

                        if (companyIndex <= _companies.Count)
                        {
                            var selectedCompany = _companies.ElementAt(companyIndex - 1);
                            var employees = selectedCompany.Employees;
                            Console.WriteLine(
                                $"Название: {selectedCompany.Name}\nОписание: {selectedCompany.Description}\n");

                            Console.Write(
                                "Выберите действие:\n1. Список сотрудников компании\n2. Назад\n3. Изменить название компании\n4. Изменить описание компании\n5. Удалить\n0. В главное меню\n> ");
                            switch (Console.ReadLine())
                            {
                                case "0":
                                    return;
                                case "1":
                                    EmployeesMenu(employees);
                                    break;
                                case "2":
                                    break;
                                case "3":
                                {
                                    Console.Write("Введите новое название компании: ");
                                    var name = Console.ReadLine();
                                    selectedCompany.EditName(name);
                                    Console.WriteLine("Готово");
                                    break;
                                }
                                case "4":
                                {
                                    Console.Write("Введите новое описание компании: ");
                                    var description = Console.ReadLine();
                                    selectedCompany.Description = description;
                                    Console.WriteLine("Готово");
                                    break;
                                }
                                case "5":
                                    _companies.Remove(selectedCompany);
                                    Console.WriteLine("Готово");
                                    break;
                                default:
                                    Console.WriteLine("\nНеверная команда\n");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nНеверная команда\n");
                        }

                        break;
                    case "2":
                        Console.Write("Введите название компании: ");
                        var companyName = Console.ReadLine();

                        Console.Write("Введите описание компании: ");
                        var companyDescription = Console.ReadLine();

                        var company = new Company(companyName, companyDescription, new List<Employee>());
                        _companies.Add(company);
                        Console.WriteLine("Готово");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("\nНеизвестная команда\n");
                        break;
                }
            }
        }

        private void EmployeesMenu(IList<Employee> employees)
        {
            Console.WriteLine("\nСписок сотрудников компании");
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employees.IndexOf(employee) + 1}. {employee.FullName}");
            }

            Console.Write(
                "\nДля просмотра информации о сотруднике введите 1. Для добавления сотрудника введите 2. Для выхода в меню компаний введите 0:\n> ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write(
                        "\nВведите номер сотрудника, чтобы узнать подробности. Для выхода в меню компаний введите 0:\n> ");
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

                        Console.Write(
                            "\nВыберите действие:\n1. Изменить фамилию и имя\n2. Изменить дату рождения\n3. Изменить ЗП\n4. Удалить\n0. Выход\n> ");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.Write("Введите фамилию и имя: ");
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
                            case "4":
                                employees.Remove(selectedEmployee);
                                Console.WriteLine("Готово");
                                break;
                            case "0":
                                break;
                            default:
                                Console.WriteLine("Введена неверная команда");
                                break;
                        }
                    }

                    break;

                case "2":
                    Console.WriteLine("Введите имя сотрудника:");
                    var nameNewEmployee = Console.ReadLine();

                    Console.WriteLine("Дата рождения:");
                    Console.Write("Введите день: ");
                    var dayNewEmployee = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите месяц: ");
                    var monthNewEmployee = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите год: ");
                    var yearNewEmployee = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите ЗП сотрудника:");
                    var salaryNewEmployee = Convert.ToInt32(Console.ReadLine());

                    var newEmployee = new Employee(nameNewEmployee,
                        new DateTime(yearNewEmployee, monthNewEmployee, dayNewEmployee), salaryNewEmployee);
                    employees.Add(newEmployee);
                    Console.WriteLine("Готово");
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("\nНеверная команда\n");
                    break;
            }
        }
    }
}