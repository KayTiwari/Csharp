using System;
using Xunit;
//NuGet.org

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTests
    {
        int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = returnMessage;
            //created WriteLogDelegate delegate
            log += returnMessage;
            log += incrementCount;
            //multicasting delegates to run multiple functions

            //logs initialized to point to this method
            var result = log("Hello");
            //log is then invoked to return a string
            // Assert.Equal("Hello", result);
            Assert.Equal(3, count);

            //Essentially log() is a keyword for returnMessage() and both invoke the same function
        }

        private string returnMessage(string message)
        {
            count++;
            return message;
        }
        private string incrementCount(string message)
        {
            count++;
            return message;
        }

        [Fact]
         public void StringsBehaveLikeValues()
        {
            string name = "Abhi";
            var newname = MakeUpperCase(name);

            Assert.Equal("ABHI", newname);

        }

        private string MakeUpperCase( string name)
        {
            return name.ToUpper();
        }

        [Fact]
        public void HowRefsArePassed()
        {
            var x = GetInt();
            SetInt(ref x);
            //have to put ref in both places

            Assert.Equal(42, x);

        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void Csharpispassbyvalue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");
            //Sending a COPY of book1 to the getbooksetname method

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        //ref keyword passess book1 as a reference instead of a value
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            setName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void setName(Book book1, string name)
        {
            book1.Name = name;
        }

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
