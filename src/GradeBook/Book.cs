using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> Grades;
        private string Name;

        public Book(string name)
        {
            this.Name = name;
            this.Grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.Grades.Add(grade);
            }
        }

        public Stats GetStats()
        {
            var result = new Stats();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in this.Grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            result.Average /= this.Grades.Count;

            return result;
        }
    }
}