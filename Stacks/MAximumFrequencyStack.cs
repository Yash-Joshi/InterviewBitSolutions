using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scaler.Stacks
{
    public class MAximumFrequencyStack
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
                    freq[element]++;
                    maxFreq = Math.Max(maxFreq, freq[element]);
                    
                    StackOfFrequency[freq[element]].Push(element);
                    ans.Add(-1);
                }
                else if (option == 2)
                {
                    int x = StackOfFrequency[maxFreq].Peek();
                    freq[x]--;
                    StackOfFrequency[maxFreq].Pop();
                    if (StackOfFrequency[maxFreq].Count() == 0)
                    {
                        maxFreq--;
                    }
                    ans.Add(x);
                }
            }
            return ans;
        }
    }
}
