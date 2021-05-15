using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.LinkedList
{
    public class RemoveElement
    {
        public static LinkedListNode<int> element(LinkedListNode<int> A, int B)
        {

            LinkedListNode<int> head = A;
            LinkedListNode<int> temp = head;
            LinkedListNode<int> prev = null;

            int c = 0;
            // Use to get the count of element in a linked list
            while (temp != null)
            {
                temp = temp.Next;
                c++;
            }

            LinkedListNode<int> t = head;
            int newC = 0;
            while (newC != B)
            {
                prev = t;
                t = t.Next;
                newC++;
            }

            t = t.Next.Next;

            return t;
        
        }
    }
}
