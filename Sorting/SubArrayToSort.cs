using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Sorting
{
   public class SubArrayToSort
    {
        public static List<int> subUnsort(List<int> A)
        {

            int[] a = A.ToArray();
            int[] original = a;

            int[] sorted = new int[a.Length];
            for (int i = 0; i < sorted.Length; i++)
            {
                sorted[i] = original[i];
            }

            Array.Sort(sorted);

            int start = 0;
            int end = 0;

            for (int i = 0; i < original.Length; i++)
            {
                if (sorted[i] != original[i])
                {
                    start = i;
                    break;
                }
            }


            for (int i = original.Length - 1; i >= 0; i--)
            {
                if (sorted[i] != original[i])
                {
                    end = i;
                    break;
                }
            }

            List<int> ret = new List<int>();

            //for (int i = start; i <= end; i++)
            //{
            //    ret.Add(original[i]);
            //}
            if (start == end)
            {
                ret.Add(-1);
                return ret;
            }

            ret.Add(start);
            ret.Add(end);

            return ret;

        }
    }
}
