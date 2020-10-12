using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAverageGrades()
        {
            // Arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(77.3);
            book.AddGrade(90.5);

            // Act
            var result = book.GetStats();

            // Assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }

        [Fact]
        public void BookAddInvalidGrade()
        {
            var book = new Book("Chris' Book");
            var result = book.AddGrade(105);

            Assert.Equal(false, result);
        }
    }
}
