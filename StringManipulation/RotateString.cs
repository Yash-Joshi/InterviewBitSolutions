using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scaler.StringManipulation
{
    public class RotateString
    {
        public static string solve(string A, int B)
        {
            char[] ch = A.ToArray();
            char[] newCh = new char[ch.Length];

            int mod = B % ch.Length;

            while (mod != 0)
            {
                char last = ch[ch.Length - 1];

                for (int i = ch.Length - 1; i > 0; i--)
                {
                    ch[i] = ch[i - 1];
                }
                ch[0] = last;
                mod--;
            }

            string finalString = new string(ch);
            return finalString;

        }
    }
}
