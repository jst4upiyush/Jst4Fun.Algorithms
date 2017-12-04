using System.Linq;
using System.Collections.Generic;

namespace Jst4Fun.Algorithms.Numeric
{
    public class Fibonacci
    {
        public IEnumerable<int> GenerateFibonaci(int length)
        {
            return GetFibonacci().Take(length);
        }

        public int GetNthItem(int length)
        {
            return GetFibonacci().ElementAt(length);
        }

        public int GetLengthForMaxItem(int maxValue)
        {
            return GetFibonacci().TakeWhile(x => x <= maxValue).Count();
        }

        private IEnumerable<int> GetFibonacci()
        {
            for (int current = 0, next = 1; true; next = current + (current = next))
                yield return current;
        }
    }
}
