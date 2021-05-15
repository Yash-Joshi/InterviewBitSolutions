using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.LinkedList
{
    public class SortingDuplicateList
    {
        public static LinkedListNode<int> sort(LinkedListNode<int> p)
        {
            LinkedListNode<int> current = p;
           
            while (current != null)
            {
                if (current.Next != null && current.Value == current.Next.Value)
                {
                    current = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }

            return current;

        }
    }
}
