using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("Sylvain's Grade Book");
            book.GradeAdded += OnGradeAdded;
            EnterGrades(book);
            var stats = book.GetStats();

            Console.WriteLine($"The highest grade is {stats.High}, the average grade is {stats.Average:N1} and the lowest grade is {stats.Low}. \n The letter grade is {stats.Letter}");
            Console.WriteLine($"The book name is: {book.Name}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                Console.WriteLine("Please enter a grade or 'q' to quit ");
                var input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added.");
        }
    }
}
