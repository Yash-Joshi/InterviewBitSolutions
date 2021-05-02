using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler
{
   public class FindPeakElement
    {
        public static int solve(List<int> A)
        {
            int[] a = A.ToArray();
            int start = 0;
            int end = a.Length - 1;

            int val = BinarySearch(a, start, end);

            return val;

        }

        public static int BinarySearch(int[] a, int start, int end)
        {
            if (start > end)
                return -1;

            int mid = (start + end) / 2;

            if (a[mid] > a[mid + 1] && a[mid] > a[mid - 1])
                return a[mid];

            if (a[mid] < a[mid - 1])
                return BinarySearch(a, start, mid);

            //if(a[mid] > a[mid + 1] && a[mid] < a[mid+1])
            if ((mid + 1) == end)
            {
                return a[end];
            }
            return BinarySearch(a, mid + 1, end);


        }
    }
}
