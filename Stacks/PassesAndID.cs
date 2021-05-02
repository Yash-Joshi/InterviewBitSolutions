using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Stacks
{
    public class PassesAndID
    {
        public static List<int> Test(List<int> A)
        {
            Stack<int> firstStack = new Stack<int>();
            Stack<int> secondStack = new Stack<int>();

            int compare = 0;

            foreach (int elements in A)
            {
                firstStack.Push(elements);
            }

            secondStack.Push(firstStack.Pop());

            int stack2var = 0;
            while (firstStack.Count != 0)
            {
                if (secondStack.Peek() > firstStack.Peek())
                {
                    secondStack.Push(firstStack.Pop());
                    continue;
                }

                if (secondStack.Peek() < firstStack.Peek())
                {
                    stack2var = secondStack.Pop();
                    secondStack.Push(firstStack.Pop());
                    secondStack.Push(stack2var);
                }

            }

            List<int> sortedList = new List<int>();
            foreach (int elements in secondStack)
            {
                sortedList.Add(elements);
            }
            return sortedList;
        }
    }
}
