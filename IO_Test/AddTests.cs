using IO_ClassLibrary;
using System;
using Xunit;

namespace IO_Test
{
    public class AddTests
    {
        [Fact]
        public void EmptyString_ReturnsZero()
        {
            var Calculator = new StringCalculator();
            var result = Calculator.Add("");

            Assert.Equal(0, result);
        }
        [Fact]
        public void SingleNumber_ReturnsValue()
        {
            var Calculator = new StringCalculator();
            var result = Calculator.Add("2");

            Assert.Equal(2, result);
        }
    }
}
