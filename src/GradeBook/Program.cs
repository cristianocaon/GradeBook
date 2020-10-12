﻿
using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grade Book");

            while (true)
            {
                System.Console.Write("Enter the grades (Press Q to quit): ");

                var input = Console.ReadLine();

                if (input.ToUpper().Equals("Q"))
                {
                    System.Console.WriteLine("=======================\n");
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                    System.Console.WriteLine($"Grade ({grade}) added to the book!\n");
                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    System.Console.WriteLine("Enter another grade");
                }
            }

            var stats = book.GetStats();

            System.Console.WriteLine($"The average is {stats.Average:N1}");
            System.Console.WriteLine($"The highest grade is {stats.High}");
            System.Console.WriteLine($"The lowest grade is {stats.Low}");
            System.Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
