using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Hashing
{
    public class LongestSubstringWithoutRepeat
    {
        public int lengthOfLongestSubstring(string A)
        {
            int temp = 0, sol = 0, i = 0, j = 0;

            Dictionary<char, int> myMap = new Dictionary<char, int>();

            while (j < A.Length)
            {
                if (!myMap.ContainsKey(A[j]))
                {
                    myMap.Add(A[j], 1);
                    j++;
                    temp++;
                }
                else
                {
                    while (A[i] != A[j])
                    {
                        myMap.Remove(A[i]);
                        i++;
                        temp--;

                    }

                    if (i != j)
                    {
                        i++;
                    }
                    temp--;
                    myMap.Remove(A[j]);
                }
                if (temp > sol)
                {
                    sol = temp;
                }

            }

            return sol;
          
        }
    }
}
