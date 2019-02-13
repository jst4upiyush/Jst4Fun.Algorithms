using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jst4Fun.Algorithms.Numeric
{
    public class PrimeGenerator
    {
        public IEnumerable<int> LessThen(int n)
        {
            var allItems = Enumerable.
                            Range(1, n).
                            ToDictionary(i => i, i => true);

            for (int p = 2; p * p <= n; p++)
            {
                // If prime[p] is not changed,
                // then it is a prime
                if (allItems[p] == true)
                {
                    // Update all multiples of p
                    for (int i = p * 2; i <= n; i += p)
                        allItems[i] = false;
                }
            }

            return allItems
                    .Where(i => i.Value)
                    .Select(i => i.Key)
                    .ToList();
        }
    }
}
