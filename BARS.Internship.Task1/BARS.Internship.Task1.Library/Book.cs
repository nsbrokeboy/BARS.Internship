using System;

namespace BARS.Internship.Task1.Library
{
    public class Book
    {
        public string Name { get; set; }

        public int CountOfPages { get; set; }

        public Book(string name, int countOfPages)
        {
            Name = name;
            CountOfPages = countOfPages;
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