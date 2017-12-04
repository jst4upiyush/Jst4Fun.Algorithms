using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jst4Fun.Algorithms.Text
{
    public class Palindrome
    {
        public bool IsPalindrome(string inputString)
        {
            return Enumerable
                .Range(0, inputString.Length / 2)
                .All(i => inputString[i] == inputString[inputString.Length - 1 - i]);
        }
    }
}
