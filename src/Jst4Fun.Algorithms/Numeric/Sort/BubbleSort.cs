using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Jst4Fun.Algorithms.Numeric.Sort
{
    public static class BubbleSort
    {
        public static void BubbleSortAscending(this IList<int> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                for (int j = 0; j < collection.Count - 1; j++)
                {
                    if (collection[j] > collection[j + 1])
                    {
                        int temp = collection[j];
                        collection[j] = collection[j+1];
                        collection[j+1] = temp;
                    }
                }
            }
        }

        public static void BubbleSortDescending(this IList<int> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                for (int j = 0; j < collection.Count - 1; j++)
                {
                    if (collection[j] < collection[j + 1])
                    {
                        int temp = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = temp;
                    }
                }
            }
        }
    }
}
