using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Searching
{
    public class FindingKinPivotedSortedArray
    {
        public static int search(List<int> A, int B)
        {

            int[] a = A.ToArray();

            int start = 0;
            int end = a.Length;

            int val = FindBinarySearchPivot(a, start, end);

            if (val == -1)
                return binarySearch(a, 0, end - 1, B);

            if (a[val] == B)
                return val;

            if (a[0] <= B)
                return binarySearch(a, 0, val - 1, B);

            return binarySearch(a, val + 1, end - 1, B);

        }

        public static int FindBinarySearchPivot(int[] a, int low, int high)
        {
            // base cases
            if (high < low)
                return -1;
            if (high == low)
                return low;

            
            /* low + (high - low)/2; */
            int mid = (low + high) / 2;

            if (mid == a.Length - 1)
            {
                return mid;
            }

            if (mid == 0)
            {
                return mid;
            }

            if (mid < high && a[mid] > a[mid + 1])
                return mid;

            if (mid > low && a[mid] < a[mid - 1])
                return (mid - 1);

            if (a[low] >= a[mid])
                return FindBinarySearchPivot(a, low, mid - 1);

            return FindBinarySearchPivot(a, mid + 1, high);

        }

        public static int binarySearch(int[] a, int low,
                                int high, int B)
        {
            if (high < low)
                return -1;

            /* low + (high - low)/2; */
            int mid = (low + high) / 2;

            if (B == a[mid])
                return mid;
            if (B > a[mid])
                return binarySearch(a, (mid + 1), high, B);

            return binarySearch(a, low, (mid - 1), B);
        }

    }
}
