using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Sylvain's Grade Book");

            while(true)
            {
                Console.WriteLine("Please enter a grade or 'q' to quit ");
                var input = Console.ReadLine();

                if(input.ToLower() == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
            var stats = book.GetStats();
            
            Console.WriteLine($"The highest grade is {stats.High}, the average grade is {stats.Average:N1} and the lowest grade is {stats.Low}. \n The letter grade is {stats.Letter}");
            Console.WriteLine($"The book name is: {book.Name}");
            Console.WriteLine(Book.CATEGORY);
        }
    }
}
