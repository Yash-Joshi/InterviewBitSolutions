using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Queues
{
    public class MaxAndMin
    {
        public static int SumOfKsubArray(int []arr,int k)
        {
            //  { 2, 5, -1, 7, -3, -1, -2 };
            int sum = 0;  // Initialize result

            // The queue will store indexes of useful elements
            // in every window
            // In deque 'G' we maintain decreasing order of
            // values from front to rear
            // In deque 'S' we  maintain increasing order of
            // values from front to rear
            List<int> S = new List<int>();
            List<int> G = new List<int>();

            // Process first window of size K1
            int i = 0;
            for (i = 0; i < k; i++)
            {

                // Remove all previous greater elements
                // that are useless.
                while (S.Count != 0 && arr[S[S.Count - 1]] >= arr[i])
                {
                    Console.WriteLine("S.Count " + S.Count);
                    //Console.WriteLine("S[S.Count] " + S[S.Count]);
                    Console.WriteLine( "S[S.Count -1] " + S[S.Count - 1]);
                    Console.WriteLine("arr[S[S.Count - 1]] " + arr[S[S.Count - 1]]);
                    Console.WriteLine("===============================");
                    S.RemoveAt(S.Count - 1); // Remove from rear

                }
                // Remove all previous smaller that are elements
                // are useless.
                while (G.Count != 0 && arr[G[G.Count - 1]] < arr[i])
                {
                    Console.WriteLine("G.Count " + G.Count);
                    //Console.WriteLine("G[G.Count] " + G[G.Count]);
                    Console.WriteLine( "G[G.Count -1]" + G[G.Count - 1]);
                    Console.WriteLine("arr[G[G.Count - 1]]" + arr[G[G.Count - 1]]);
                    Console.WriteLine("===============================");
                    G.RemoveAt(G.Count - 1); // Remove from rear

                }

                // Add current element at rear of both deque
                G.Add(i);
                S.Add(i);
            }

            // Process rest of the Array elements
            for (; i < arr.Length; i++)
            {

                // Element at the front of the deque 'G' & 'S'
                // is the largest and smallest
                // element of previous window respectively
                sum += arr[S[0]] + arr[G[0]];

                // Remove all elements which are out of this
                // window
                while (S.Count != 0 && S[0] <= i - k)
                    S.RemoveAt(0);
                while (G.Count != 0 && G[0] <= i - k)
                    G.RemoveAt(0);

                // remove all previous greater element that are
                // useless
                while (S.Count != 0 && arr[S[S.Count - 1]] >= arr[i])
                {
                    S.RemoveAt(S.Count - 1); // Remove from rear
                }

                // remove all previous smaller that are elements
                // are useless
                while (G.Count != 0 && arr[G[G.Count - 1]] <= arr[i])
                {
                    G.RemoveAt(G.Count - 1); // Remove from rear
                }

                // Add current element at rear of both deque
                G.Add(i);
                S.Add(i);
            }

            // Sum of minimum and maximum element of last window
            sum += arr[S[0]] + arr[G[0]];
            Console.WriteLine(sum);
            return sum;
        }
    }
}
