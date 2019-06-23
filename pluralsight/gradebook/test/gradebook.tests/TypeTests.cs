using System;
using Xunit;
//NuGet.org

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // Assert.Equal("Book 1", book1.Name);
            // Assert.Equal("Book 1", book2.Name);

            Assert.Same(book1, book2);
            //both objects point to same area in memory

            Assert.True(Object.ReferenceEquals(book1, book2));
            //Both values reference same object
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
