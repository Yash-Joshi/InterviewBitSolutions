using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Queues
{
    public class SlidingWindowMax
    {
        public static List<int> MaxInList(int[] a,int k)
        {
            int[] arr = a;

            List<int> Qi = new List<int>();
            List<int> toReturn = new List<int>();
            /* Process first k (or first window) 
                   elements of array */
            int i;
            for (i = 0; i < k; ++i)
            {
                // For every element, the previous 
                // smaller elements are useless so
                // remove them from Qi
                while (Qi.Count != 0 && arr[Qi.IndexOf(0)] >= arr[i] )

                    // Remove from rear
                    Qi.RemoveAt(Qi.Count - 1);

                // Add new element at rear of queue
                Qi.Insert(Qi.Count, i);
            }

            // Process rest of the elements, 
            // i.e., from arr[k] to arr[n-1]
            for (; i < arr.Length; ++i)
            {
                // The element at the front of 
                // the queue is the largest element of
                // previous window, so print it
                Console.Write(arr[Qi[0]] + " ");

                // Remove the elements which are 
                // out of this window
                while ((Qi.Count != 0) && Qi[0] <= i - k)
                    Qi.RemoveAt(0);

                // Remove all elements smaller 
                // than the currently
                // being added element (remove 
                // useless elements)
                while ((Qi.Count != 0) && arr[i] >=
                               arr[Qi[Qi.Count - 1]])
                    Qi.RemoveAt(Qi.Count - 1);

                // Add current element at the rear of Qi
                Qi.Insert(Qi.Count, i);
            }

            // Print the maximum element of last window
            Console.Write(arr[Qi[0]]);

            return Qi;
        }
    }
}
