using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Sorting
{
    public class WaveArray
    {
        public static List<int> wave(List<int> A)
        {
            int[] a = A.ToArray();
            Array.Sort(a);

            int len = a.Length;

           
            List<int> waveArray = new List<int>();

            if (len == 1)
            {
                int v = a[0];
                waveArray.Add(v);
                return waveArray;

            }

            if (len % 2 != 0)
            {
                int last = a[len - 1];

                for (int i = 0; i < len - 1; i = i+2)
                {
                   
                    waveArray.Add(a[i + 1]);
                    waveArray.Add(a[i]);
                }
                waveArray.Add(last);

            }

            if (len % 2 == 0)
            {
                
                for (int i = 0; i < len - 1; i = i+ 2)
                {
                    waveArray.Add(a[i + 1]);
                    waveArray.Add(a[i]);
                }
               

            }

            return waveArray;
        }


        public static void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return;

        }
    }
}
