using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Hashing
{
    public class ColorfulNumber
    {
        public static int colorful(int A)
        {

            List<int> AA = new List<int>();

            while (A !=0)
            {
                AA.Add(A % 10);
                A = A / 10;
            }

            int[] a = AA.ToArray();
            Array.Reverse(a);
            HashSet<int> ap = new HashSet<int>();

            for (int i = 0; i < a.Length; i++)
            {
               int product = 0;
                for (int j = i; j < a.Length; j++)
                {
                    product *= a[j];
                    if (ap.Contains(product))
                    {
                        return 0;
                    }
                    else
                    {
                        ap.Add(product);
                    }
                }
            }
            return 1;
        }
    }
}
