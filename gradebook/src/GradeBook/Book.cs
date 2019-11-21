using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value.");
            }
            
        }
        public Statistics GetStats()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
             
             //multiple option of loops
             //Lopp type 1: do while
            /*var index = 0;
            do
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
                index ++;
            }while(index < grades.Count);*/

            //loop type 2: while
            /*var index = 0;
            while(index < grades.Count)
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
                index ++;
            }*/

            //loop type 3: for
            for(var index = 0; index < grades.Count; index ++)
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
            }
            result.Average /= grades.Count;

            return result;
        }
        public List<double> grades;
        public string Name;
    }
}
