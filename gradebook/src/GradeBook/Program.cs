using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Sylvain's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(98.5);
            book.AddGrade(74.6);
            var stats = book.GetStats();

            Console.WriteLine($"The highest grade is {stats.High}, the average grade is {stats.Average:N1} and the lowest grade is {stats.Low}.");
        }
    }
}
