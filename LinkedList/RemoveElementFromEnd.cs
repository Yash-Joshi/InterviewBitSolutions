using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.LinkedList
{
    public class RemoveElementFromEnd
    {
        public static LinkedListNode<int> removeNthFromEnd(LinkedListNode<int> A, int B)
        {

            LinkedListNode<int> head = A;
            LinkedListNode<int> temp = head;
            
            int elementToRemoveFromStart = 0;

            int count = 0;
            while (temp != null && temp.Next != null)
            {
                count++;
                temp = temp.Next;
            }

            if (B > count)
            {
                head = head.Next;
                return head;
            }

            elementToRemoveFromStart = count - B;
            
            int aCount = 0;
            LinkedListNode<int> prev = head;
            LinkedListNode<int> current = head;
            while (aCount != elementToRemoveFromStart)
            {
                aCount++;
                prev = prev.Next;
                current = prev.Next;
            }

            prev = current.Next;
           // prev.Next = current.Next;

            return prev;
        }

    }
}
