using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.LinkedList
{
    public class RemoveElementFromEnd
    {
        public LinkedListNode removeNthFromEnd(LinkedListNode A, int B)
        {


            LinkedListNode head = A;
            LinkedListNode temp = head;
            LinkedListNode checkMatch = head;
            int elementToRemoveFromStart = 0;
            int count = 0;
            while (temp != null && temp.Next != null)
            {
                count++;
                temp = temp.Next;
            }

            if (B > count)
            {
                return A;
            }

            else
            {
                elementToRemoveFromStart = count - B;
            }

            while (count != elementToRemoveFromStart - 1)
            {
                checkMatch = checkMatch.Next;
            }

            checkMatch.next = checkMatch.Next.Next;

            return A;
        }

    }
}
