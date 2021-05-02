
using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Hashing
{
    /// <summary>
    /// Given two array of integers A and B, Sort A in such a way that the relative order among the elements will be the same as those are in B. 
    /// For the elements not present in B, append them at last in sorted order.
    ///  Return the array A after sorting from the above method. NOTE: Elements of B are unique.
    /// </summary>
    public class SortArrayInGivenWay
    {
        public static List<int> solve(List<int> A, List<int> B)
        {

            int[] a = A.ToArray();
            Array.Sort(a);

            int[] b = B.ToArray();  

            List<int> retItems = new List<int>();
            Dictionary<int, int> sortArrayFrequencyCount = new Dictionary<int, int>();

            foreach (int items in a)
            {
                if (sortArrayFrequencyCount.ContainsKey(items))
                {
                    sortArrayFrequencyCount[items] += 1;
                }
                else {
                    sortArrayFrequencyCount.Add(items,1);
                }
            }

            for (int j = 0; j < b.Length; j++)
            {
                if (sortArrayFrequencyCount.ContainsKey(b[j]))
                {
                    int value = sortArrayFrequencyCount[b[j]];

                    while (value > 0)
                    {
                        retItems.Add(b[j]);
                        value--;
                    }
                    sortArrayFrequencyCount.Remove(b[j]);

                }
            }

            foreach (int remainingItems in sortArrayFrequencyCount.Keys)
            {
                int value = sortArrayFrequencyCount[remainingItems];

                while (value > 0)
                {
                    retItems.Add(remainingItems);
                    value--;
                }
                sortArrayFrequencyCount.Remove(remainingItems);
            }

            return retItems;
        }
    }
}
