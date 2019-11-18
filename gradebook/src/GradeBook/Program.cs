using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>(){12.7, 58.0, 16.3};
            grades.Add(56.1);

            var result = 0.0;
            foreach (var grade in grades)
            {
                result += grade;
            }
            Console.WriteLine ($"The result is {result}.");

            var avergage = result / grades.Count;
            Console.WriteLine($"The average grade is {avergage:N1}.");
 
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!"); //String interpolation
            }
            else
            {
                Console.WriteLine("Hello!");
            }

        }
    }
}
