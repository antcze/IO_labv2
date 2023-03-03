using IO_ClassLibrary;
using System;
using Xunit;

namespace IO_Test
{
    public class AddTests
    {
        [Fact]
        public void EmptyString_Should_ReturnZero()
        {
            var Calculator = new StringCalculator();
            var result = Calculator.Add("");

            Assert.Equal(0, result);
        }
        [Theory]
        [InlineData("2",2)]
        [InlineData("15", 15)]
        public void SingleNumber_Should_ReturnValue(string input, int expected)
        {
            var Calculator = new StringCalculator();
            var result = Calculator.Add(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2,3",5)]
        [InlineData("11,9",20)]
        public void TwoNumbersSeparatedByComma_Should_ReturnSum(string input, int expected)
        {
            var Calculator = new StringCalculator();
            var result = Calculator.Add(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2\n3", 5)]
        [InlineData("11\n9", 20)]
        public void TwoNumbersSeparatedByNewLine_Should_ReturnSum(string input, int expected)
        {
            var Calculator = new StringCalculator();
            var result = Calculator.Add(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2\n3,6", 11)]
        [InlineData("1,11\n9", 21)]
        public void ThreeNumbersSeparatedFreelyByNewlineOrComma_Should_ReturnSum(string input, int expected)
        {
            var Calculator = new StringCalculator();
            var result = Calculator.Add(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2\n3,-6")]
        [InlineData("1,-11\n9")]
        [InlineData("-3")]
        public void NegativeNumber_Should_ThrowAnException(string input)
        {
            var Calculator = new StringCalculator();

            Assert.Throws<ArgumentOutOfRangeException>(()=>Calculator.Add(input));
        }
    }
}
