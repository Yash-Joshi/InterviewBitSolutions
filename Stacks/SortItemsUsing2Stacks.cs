using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Stacks
{
    public class SortItemsUsing2Stacks
    {
        public static List<int> solve(List<int> A)
        {
            int[] a = { 66, 96, 43, 28, 14, 1, 41, 76, 70, 81, 22, 11, 42, 78, 4, 88, 70, 43, 90, 6, 12 };

            Stack<int> stack1 = new Stack<int>();
            Stack<int> temp = new Stack<int>();
            // inserting elements in stack 1
            foreach (int item in a)
            {
                stack1.Push(item);
            }
            while (stack1.Count != 0)
            {
                //int popedElementFromStack1 = stack1.Pop();
                if (temp.Count == 0)
                {
                    temp.Push(stack1.Pop());
                    continue;
                }

                if (temp.Peek() > stack1.Peek()) // && temp.Count != 0
                {
                    temp.Push(stack1.Pop());
                }
                while (temp.Peek() < stack1.Peek())
                {
                    int v = temp.Pop();
                    temp.Push(stack1.Pop());
                    stack1.Push(v);
                }

            }
            List<int> sortedArray = new List<int>();
            foreach (int items in temp)
            {
                sortedArray.Add(items);
            }
            return sortedArray;
        }
    }
}
