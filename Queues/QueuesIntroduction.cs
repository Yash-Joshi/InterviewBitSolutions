using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Queues
{
    class QueuesIntroduction
    {
        public static List<int> solve(int A)
        {
            Queue<int> q = new Queue<int>();
            List<int> finalList = new List<int>();

            if (A < 3)
            {
                int count = 0;
                while (count < A)
                {
                    count++;
                    q.Enqueue(count);
                }
            }

            if (A > 3)
            {
                int count = 1;
               // int n = q.Peek();
                int i = 1;
                while (count <= A)
                {
                    if (q.Count < 3)
                    {
                        q.Enqueue(count);
                        finalList.Add(count);
                        count++;
                    }

                    else
                    {
                        int n = q.Peek();
                        if (i > 3)
                        {
                            i = 1;
                            q.Dequeue();
                            n = q.Peek();
                        }
                        
                        q.Enqueue(n * 10 + i);
                        finalList.Add(n * 10 + i);
                        i++;
                        count++;
                        
                    }
                }

            }
            return finalList;
        }
    }
}
