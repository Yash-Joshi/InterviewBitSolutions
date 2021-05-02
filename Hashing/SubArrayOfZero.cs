using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Hashing
{
    public class SubArrayOfZero
    {
        public static int solve(List<int> A)
        {
            int[] a = A.ToArray();

            int sum = 0;
            HashSet<int> check = new HashSet<int>();

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                if (check.Contains(sum))
                {
                    return 1;
                }
                if (sum == 0)
                {
                    return 1;
                }
                else
                {
                    check.Add(sum);
                }
            }

            return 0;
        }
    }
}
