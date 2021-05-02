using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Recursion
{
    public class sixlets
    {
        public int solve(List<int> A, int B)
        {

            int[] a = A.ToArray();
            int count = 0;
            int sum = 0;
            int ans = 0;
            int index = 0;

            int val = func(a, B, count, ans,sum, index);
            return val;
        }

        public static int func(int[] a, int B, int count, int ans, int sum, int index)
        {
            if (sum > 1000)
            {
                return ans;
            }

            if (count == B)
            {
                ans += 1;
                return ans;
            }

            if (index == a.Length - 1)
            {
                return ans;
            }


            return func(a, B, count + 1, ans, sum + a[index],  index + 1);

            return func(a, B, count , ans, sum , index);
        }
    }
}
