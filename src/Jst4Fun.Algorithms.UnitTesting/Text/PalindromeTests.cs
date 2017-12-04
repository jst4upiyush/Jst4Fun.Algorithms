using Jst4Fun.Algorithms.Text;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Jst4Fun.Algorithms.UnitTesting.Text
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("aba", true)]
        [InlineData("abc", false)]
        public void IsPalindromeTest(string inputString, bool isPalindrome)
        {
            var palindrome = new Palindrome();
            bool isPalindromeResult = palindrome.IsPalindrome(inputString);
            Assert.Equal(isPalindrome, isPalindromeResult);
        }
    }
}
