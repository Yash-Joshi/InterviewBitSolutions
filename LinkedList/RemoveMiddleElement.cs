using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.LinkedList
{
    public class RemoveMiddleElement
    {
        public static int RemoveMiddleElementFromList(LinkedListNode<int> A)
        {
            LinkedListNode<int> head = A;
            LinkedListNode<int> slow = head;
            LinkedListNode<int> fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return slow.Value;
        }
    }
}
