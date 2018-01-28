using Jst4Fun.Algorithms.Numeric;
using Xunit;

namespace Jst4Fun.Algorithms.UnitTesting.Numeric
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        public void NthValueTest(int lenght, int value)
        {
            var fibonacci = new Fibonacci();
            Assert.Equal(value, fibonacci.GetNthItem(lenght));
        }

        [Theory]
        [InlineData(10, 7)]
        public void LenghtForMaxValueTest(int maxValue, int expectedLength)
        {
            var fibonacci = new Fibonacci();
            int length = fibonacci.GetLengthForMaxItem(maxValue);
            Assert.Equal(expectedLength, length);
        }
    }
}
