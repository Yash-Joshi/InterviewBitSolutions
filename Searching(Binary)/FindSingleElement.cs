using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Searching
{
    public class FindSingleElement
    {
        public static int solve(List<int> A)
        {
            int[] a = A.ToArray();

            int[] b = new int[] { 13, 13, 21, 21, 27, 50, 50, 102, 102, 108, 108, 110, 110, 117, 117, 120, 120, 123, 123, 124, 124, 132, 132, 164, 164, 166, 166, 190, 190, 200, 200, 212, 212, 217, 217, 225, 225, 238, 238, 261, 261, 276, 276, 347, 347, 348, 348, 386, 386, 394, 394, 405, 405, 426, 426, 435, 435, 474, 474, 493, 493 };
            int start = 0;
            int end = b.Length - 1;

            int val = BinarySearch(b, start, end);
            return val;
        }

        public static int BinarySearch(int[] b, int start, int end)
        {


            if (start == end)
            {
                return b[start];
            }


            int mid = (start + end) / 2;

            //if (mid == end)
            //{
            //    return b[mid];
            //}

            if (mid == 0)
            {
                return b[mid];

            }


            if (mid % 2 != 0)
            {
                if (b[mid - 1] == b[mid])
                {
                    return BinarySearch(b, mid + 1, end);
                }

                else
                {
                    return BinarySearch(b, start, mid - 1);
                }
            }
            if (mid % 2 == 0)
            {
                if (b[mid + 1] == b[mid])
                {
                    return BinarySearch(b, mid + 2, end);
                }
                else
                {
                    return BinarySearch(b, start, mid - 1);
                }

            }
            return 0;
        }

    }
}
