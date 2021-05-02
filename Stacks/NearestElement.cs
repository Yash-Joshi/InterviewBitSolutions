using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Stacks
{
    public class NearestElement
    {
        public static List<int> prevSmaller(List<int> A)
        {

            Stack<int> smallStack = new Stack<int>();
            List<int> finalList = new List<int>();

            int min = Int32.MaxValue;
            int newMin = min;
            for (int i = 0; i < A.Count; i++)
            {
                if (smallStack.Count == 0 && i == 0)
                {
                    //Since no left element is there
                    finalList.Add(-1);
                    smallStack.Push(A[i]);
                    min = -1;
                    newMin = -1;
                    continue;
                }

                while (smallStack.Count > 0 && smallStack.Peek() >= A[i])
                {
                    min = smallStack.Pop();
                    //newMin = min;
                }

                if (smallStack.Count > 0)
                {
                    finalList.Add(smallStack.Peek());
                }

                else
                {
                    finalList.Add(-1);
                }
                smallStack.Push(A[i]);
            }

            return finalList;



        }
    }
}
