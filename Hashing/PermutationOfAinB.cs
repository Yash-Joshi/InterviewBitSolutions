using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Hashing
{
    public class PermutationOfAinB
    {
        public static int solve(string A, string B)
        {

            char[] a = A.ToCharArray();

            char[] b = B.ToCharArray();

            IDictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in a)
            {
                if (freq.ContainsKey(c))
                {
                    freq[c] += 1;
                }
                else
                    freq.Add(c, 1);
            }

            int start = 0;
            int end = a.Length - 1;
            int count = 0;
            bool isEqual;

            if (start == end)
            {
                // it means there is only one character input
                int countBoundry = 0;
                for (int i = 0; i < b.Length; i++)
                {
                    if (b[i].ToString() == a[0].ToString())
                    {
                        countBoundry++;
                    }
                }
                return countBoundry;
            }

            IDictionary<char, int> toMatch = new Dictionary<char, int>();
            for (int p = 0; p < b.Length; p++)
            {

                int matchStart = p;
                int matchEnd = p + end;

                if (matchEnd < b.Length)
                {
                    //Create another Hash

                    for (int i = matchStart; i <= matchEnd; i++)
                    {
                        if (toMatch.ContainsKey(b[i]))
                        {
                            toMatch[b[i]] += 1;
                        }
                        else
                            toMatch.Add(b[i], 1);
                    }
                    //Compare 2 hash functions
                    isEqual = compareFun(freq, toMatch);

                    //if true increment the count of Permutation
                    if (isEqual)
                        count++;
                    // else continue

                    toMatch.Remove(b[matchStart]);

                    continue;

                }
            }

            return count;
        }

        private static bool compareFun(IDictionary<char, int> d, IDictionary<char, int> d2)
        {
            bool equal = false;
            if (d.Count == d2.Count)
            { // Require equal count.
                //equal = true;
                foreach (var pair in d)
                {
                    int value;
                    if (d2.TryGetValue(pair.Key, out value))
                    {
                        if (value != pair.Value)
                        {
                            equal = false;
                            break;
                        }
                        equal = true;
                    }
                    else
                    {
                        equal = false;
                        break;
                    }
                }
                
            }
            return equal;
        }
    }
}
