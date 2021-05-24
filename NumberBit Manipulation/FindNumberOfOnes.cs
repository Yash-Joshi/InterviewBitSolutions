using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.NumberBit_Manipulation
{
    public class FindNumberOfOnes
    {
        public static int numSetBits(int A)
        {

            //Convert the number to decimal 
            //then count the number of 1's 
            int b = A;

            List<int> sb = new List<int>();
            while (b > 0)
            {
                int m = b % 2;
                b = b / 2;
                // Console.WriteLine("B value {0}", b);
                // Console.WriteLine("M value {0}", m);
                sb.Add(m);
            }

            int count = 0;
            foreach (int v in sb)
            {
                if (v == 1)
                {
                    count++;
                }
            }



            return count;
        }
    }
}
