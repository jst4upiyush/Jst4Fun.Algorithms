using Jst4Fun.Algorithms.Numeric;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Jst4Fun.Algorithms.UnitTesting.Numeric
{
    public class PrimeNumbersTests
    {
        [Theory]
        [InlineData(3, new[] { 1, 2, 3 })]
        [InlineData(5, new[] { 1, 2, 3 , 5})]
        public void TestPrimeNumbersLessThan(int number, IEnumerable<int> expected)
        {
            var primeGenerator = new PrimeGenerator();

            var primes = primeGenerator.LessThen(number);

            Assert.Equal(expected, primes);
        }
    }
}
