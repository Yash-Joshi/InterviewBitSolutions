using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Problem_Solving
{
    public class AGSubSequence
    {
        public int solve(string A)
        {

            char[] c = A.ToCharArray();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int p = 0;
            int s = 0;
            int count = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 65 || c[i] == 71)
                {
                    sb = sb.Append(c[i].ToString());
                }
                // A = 65 G= 71
                if (c[i] != 65)
                {
                    continue;
                }

                // BBAPPGAG
                if (c[i] == 65)
                {
                    p = i;
                    s = i + 1;

                    while (s < c.Length)
                    {
                        if (c[s] == 71)
                        {
                            count++;
                        }
                        s++;
                    }
                }
            }

            return count;
        }
    }
}
