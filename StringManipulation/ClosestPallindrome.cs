using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scaler.StringManipulation
{
    public class ClosestPallindrome
    {
        public static string solve(string A)
        {
            char[] charArr = A.ToArray();

            int start = 0;
            int end = charArr.Length - 1;
            int size = charArr.Length;
            //char temp = '';
            int changeCount = 0;

            while (start < end)
            {
                if (charArr[start] == charArr[end])
                {
                    start++;
                    end--;
                    continue;
                }
                else
                {
                    start++;
                    end--;
                    changeCount += 1;
                }

            }
            if (changeCount > 1)
            {
                return "NO";
            }
            else if (changeCount == 0 && size % 2 == 0)
            {
                return "NO";
            }

            else if (changeCount == 0 && size % 2 != 0)
            {
                return "YES";
            }

            else if (changeCount == 1 && size % 2 == 0)
            {
                return "YES";
            }
            else if (changeCount == 1 && size % 2 != 0)
            {
                return "YES";
            }
            return "NO";

        }
    }
}
