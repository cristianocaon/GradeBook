
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grade Book");
            book.AddGrade(89.9);
            book.AddGrade(74.0);
            book.AddGrade(96.0);
            book.AddGrade(60.5);

            var stats = book.GetStats();

            System.Console.WriteLine($"The average is {stats.Average:N1}");
            System.Console.WriteLine($"The highest grade is {stats.High}");
            System.Console.WriteLine($"The lowest grade is {stats.Low}");
        }
    }
}
