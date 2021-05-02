using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Stacks
{
    class Solution
    {

        public List<int> solve(List<List<int>> A)
        {



            Dictionary<int, int> freq = new Dictionary<int, int>();

            Dictionary<int, Stack<int>> StackOfFrequency = new Dictionary<int, Stack<int>>();

            List<int> ans = new List<int>();

            int maxFreq = 0;

            for (int i = 0; i < A.Count; i++)

            {

                int option = A[i][0];

                int element = A[i][1];

                if (option == 1)

                {

                    if (!freq.ContainsKey(element))
                    {

                        freq.Add(element, 0);

                    }

                    freq[element]++;

                    maxFreq = Math.Max(maxFreq, freq[element]);

                    if (!StackOfFrequency.ContainsKey(freq[element]))
                    {

                        StackOfFrequency.Add(freq[element], new Stack<int>());

                    }

                    StackOfFrequency[freq[element]].Push(element);

                    ans.Add(-1);

                }

                else if (option == 2)

                {

                    int x = StackOfFrequency[maxFreq].Peek();

                    freq[x]--;

                    StackOfFrequency[maxFreq].Pop();


                    ans.Add(x);

                }

            }

            return ans;

        }

    }
}
