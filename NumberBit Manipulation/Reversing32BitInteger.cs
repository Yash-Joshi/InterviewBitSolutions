using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.NumberBit_Manipulation
{
    public class Reversing32BitInteger
    {
        public static long solve(int A)
        {
            long num = 0;
            int i = 31; 
            while (A > 0)
            {
                num += (A % 2) * (long)System.Math.Pow(2, i);
                Console.Write(num + " ");
                i--;
                A = A / 2;
            }

            return num;
        }
    }
}
