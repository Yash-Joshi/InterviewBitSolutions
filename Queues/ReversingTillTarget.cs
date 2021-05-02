using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Queues
{
    public class ReversingTillTarget
    {
        public static List<int> solve(List<int> A, int B)
        {

            Queue<int> q = new Queue<int>();
            Stack<int> s = new Stack<int>();

            List<int> finalList = new List<int>();
        
        foreach(int item in A)
            {
                q.Enqueue(item);
            }
            int count = 0;
            while (count != B)
            {
                s.Push(q.Dequeue());
                count++;
            }

            while (s.Count != 0)
            {
                q.Enqueue(s.Pop());
            }

            int size = q.Count - B;

            for (int i = 0; i < size; i++)
            {
                q.Enqueue(q.Dequeue());
            }
        
        foreach(int i in q)
            {
                finalList.Add(i);
            }

            return finalList;
        }
    }
}
