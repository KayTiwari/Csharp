using System;
using Xunit;
//NuGet.org

namespace GradeBook.Tests
{
    public class BookTests
    {

        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var result = book.GetStatistics();

            Assert.Equal(85.6, result.Average, 1);
            //3rd parameter is precision of decimal place
            Assert.Equal(90.5, result.High);
            Assert.Equal(77.3, result.Low);

        }
    }
}
