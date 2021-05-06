using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.TwoPointers
{
    public class SubArrayWithGivenSum
    {
        public static List<int> solve(List<int> A, int B)
        {
            int[] ans = A.ToArray();
            long n = A.Count;
            int l = 0, r = 0;
            long sum = A[l];
            int[] ans2 = new int[l];
            while (r < n && l <= r)
            {
                if (sum == B)
                {
                     ans2 = new int[r - l + 1];
                    for (int i = l; i <= r; i++) ans2[i - l] = A[i];
                    break;
                    //return ans;
                }
                if (sum < B)
                {
                    r++;
                    if (r < n) sum += A[r];
                }
                else
                {
                    sum -= A[l];
                    l++;
                }
            }

            List<int> ret = new List<int>();
            foreach (int i in ans2) 
            {
                ret.Add(i);
            }

            if (ans2.Length == 0)
            {
                ret.Add(-1);
                return ret;
            }
            return ret;
        }
    }
}
