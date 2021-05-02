using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Searching
{
    public class FindingRootUsingBinary 
    {
        public static int sqrt(int A)
        {

            int start = 0;
            int end = A;
            int ans = 0;

            if (A.CompareTo(1) == 0)
            {
                return A;
            }



            while (start < end)
            {


                int mid = start + (end - start) / 2;

                if (mid <= (A / mid))
                {
                    ans = mid;
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return ans;
        }
    }
}
