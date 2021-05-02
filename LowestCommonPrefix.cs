using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler
{
    public class LowestCommonPrefix
    {
        public static string longestCommonPrefix(List<string> A)
        {

            string[] stringA = A.ToArray();

            LengthWiseSort(stringA);
            //Array.Sort(stringA, StringComparer.InvariantCulture);

            string small = stringA[0];
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i <= small.Length - 1; i++)
            {
                char ch = small[i];
                bool isQualified = true;

                for (int j = 0; j <= stringA.Length - 1; j++)
                {
                    if (stringA[j][i] == ch)
                    {
                        
                        continue;
                    }
                    else if (stringA[j][i] != ch)
                    {
                        isQualified = false;
                        break;
                    }

                   
                }

                if (isQualified)
                {
                    sb = sb.Append(ch);
                }
                else
                {
                    return sb.ToString();
                }
            }

            return sb.ToString();

        }

        private static void LengthWiseSort(string[] s)
        {
            for (int i = 1; i < s.Length; i++)
            {
                string temp = s[i];

                // Insert s[j] at its correct position
                int j = i - 1;
                while (j >= 0 && temp.Length < s[j].Length)
                {
                    s[j + 1] = s[j];
                    j--;
                }
                s[j + 1] = temp;
            }
        }
    }
}
