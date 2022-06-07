using System;

namespace BARS.Internship.Task1.Library
{
    public class Book
    {
        protected string Name { get; }

        private int _countOfPages;

        public static bool IsUselessFiled { get; private set; }

        public int CountOfPages
        {
            get => _countOfPages;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество страниц не может быть меньше 0");
                }

                _countOfPages = value;
            }
        }

        public Book(string name, int countOfPages)
        {
            Name = name;
            CountOfPages = countOfPages;
        }

        // статический конструктор вызывается один раз при первом создании объекта - для инициализации статических данных,
        // либо для выполнения операция, которые требуются только один рза
        static Book()
        {
            IsUselessFiled = true;
        }

        public void TearOutThePage(int pages)
        {
            if (CountOfPages - pages >= 0)
            {
                CountOfPages -= pages;
            }
            else Console.WriteLine("В книге страниц меньше, чем нужно вырвать");

            Console.WriteLine($"Вы вырвали {pages} стр из книги {Name}. Теперь в ней {CountOfPages} стр.");
        }
    }
}