using FluentAssertions;
using Jst4Fun.Algorithms.Numeric.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Jst4Fun.Algorithms.UnitTesting.Numeric.Sort
{
    public class BubbleSortTests
    {
        [Fact]
        public static void DoTest()
        {
            var list = new List<int>() { 23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25 };
            list.BubbleSortAscending();
            int[] sortedList = { 0, 2, 3, 4, 8, 9, 12, 15, 16, 23, 25, 34, 42, 46, 55 };
            list.Should().BeEquivalentTo(sortedList, option => option.WithStrictOrdering());
        }
    }
}
