using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.StringManipulation
{
    public class ReverseString
    {
        public static string solve(string A)
        {
            string[] s = A.Split(' ');

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    sb = sb.Append(s[i].ToString());
                    break;
                }
                else
                {
                    sb = sb.Append(s[i] + " ");
                }
            }

            
            string st = sb.ToString();
            
           // st.Trim();

            return st;
        }
    }
}
