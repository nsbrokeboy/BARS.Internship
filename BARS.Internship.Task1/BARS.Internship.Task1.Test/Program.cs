using BARS.Internship.Task1.Library;

namespace BARS.Internship.Task1.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ромео и Джульетта, Уильям Шекспир", 160);
            book.TearOutThePage(3);
        }
    }
}