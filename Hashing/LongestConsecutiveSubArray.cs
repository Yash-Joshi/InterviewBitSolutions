using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Hashing
{
    public class LongestConsecutiveSubArray
    {
        public static int longestConsecutive(List<int> A)
        {

            HashSet<int> itemElements = new HashSet<int>();

            foreach (int elements in A)
            {
                itemElements.Add(elements);
            }

            int copy = 0;
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < A.Count; i++)
            {
                copy = A[i];
                if (!itemElements.Contains(copy - 1))
                {
                    count = 1;
                    while (itemElements.Contains(copy + 1))
                    {
                        copy++;
                        count++;
                    }

                    maxCount = Math.Max(maxCount, count);

                }
              
            }

            return maxCount;

        }
    }
}
