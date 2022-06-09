using System;
using System.Collections.Generic;
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
            // todo: вывод компаний и меню редактирования, обернуть в while
            Console.WriteLine("Список компаний:");
            int index = 1;
            foreach (var company in _companies)
            {
                Console.WriteLine($"{index}. {company.Name}");
                index++;
            }

            Console.WriteLine();
            Console.WriteLine("Выберите действие:\n1. Подробнее о компании...\n2. Назад");
            switch (Console.ReadLine())
            {
                case "1":
                    //
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Неверная команда");
                    break;
            }
        }
        
        // метод выводит всех сотрудников компании
    }
}