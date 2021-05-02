using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Sorting
{
    public class CheckSort
    {
        public static int solve(List<int> A)
        {

            int[] a = A.ToArray();

            int i = 0;
            int max = Math.Max(a[i], a[a[i]]);
            int chunk = 0;

            for ( i = 0; i < a.Length; i++)
            {


                if (i == max)
                {
                    chunk++;
                    max = Math.Max(a[i], a[a[i]]);
                }
            }

            return chunk;
            }
    }
}
