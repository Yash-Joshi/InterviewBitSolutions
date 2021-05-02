using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Hashing
{
   public class FindingSubArrayOfSum
    {
        class Solution
        {
            public static List<int> solve(List<int> A, int B)
            {
                int[] a = A.ToArray();

                int l = 0;
                int r = 1;
                int sum = a[0];
                List<int> ret = new List<int>();

                if (a.Length == 2)
                {
                    if (a[0] == B)
                    {
                        ret.Add(a[0]);
                        return ret;

                    }
                    else if (a[1] == B)
                    {
                        ret.Add(a[1]);
                        return ret;
                    }

                    else if ((a[0] + a[1]) == B)
                    {
                        ret.Add(a[0]);
                        ret.Add(a[1]);
                        return ret;
                    }
                    else
                    {
                        ret.Add(-1);
                        return ret;
                    }
                }

                for (r = 1; r < a.Length; r++)
                {
                    while (sum > B && l <= r)
                    {
                        sum = sum - A[l];
                        l++;
                    }
                    if (sum == B)
                    {
                        for (int k = l; k < r; k++)
                        {
                            ret.Add(a[k]);

                        }

                        return ret;
                    }

                    if (r <= a.Length)
                    {
                        sum = sum + a[r];
                    }
                }

                ret.Add(-1);
                return ret;

            }
        }

    }
}
