using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scaler.Hashing
{
   public class Anagrams
    {
        public static List<List<int>> anagrams(List<string> A)
        {

            string[] a = A.ToArray();
            
            List<List<int>> up = new List<List<int>>();
            Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();

            for (int i = 0; i < a.Length; i++)
            {
                char[] p = a[i].ToArray();
                Array.Sort(p);
                string s = new string(p);
                Console.WriteLine(s);
                if (map.ContainsKey(s))
                {
                    List<int> li = map[s];
                    int c = i;
                    li.Add(c+1);
                    map[s] = li;
                }
                else
                {
                    List<int> val = new List<int>();
                    int c = i;
                    val.Add(c+1);
                    map.Add(s, val);
                }


            }

            foreach (List<int> items in map.Values)
            {
                up.Add(items);
            }


            return up;

        }
    }
}
