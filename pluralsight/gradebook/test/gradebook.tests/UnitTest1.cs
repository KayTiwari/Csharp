using System;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        //FAct is an attribute 
        public void Test1()
        {
            //arrange
            var x = 5;
            var y = 2;
            var expected = 10;

            //act
            var actual = x * y;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
