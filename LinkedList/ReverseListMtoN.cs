using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.LinkedList
{
    public class ReverseListMtoN
    {
        /// <summary>
        /// Algorithm
        /// Find the point B and C in a Linked List where we need to do the reversal
        /// Reverse the list using the reverseAB function and return 
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public static ListNode reverse(ListNode A, int B, int C)
        {

            if (B == C)
            {
                return A;
            }

            ListNode reverse_Start = null;
            ListNode reverse_End = null;
            ListNode reverse_Start_Previous = null;
            ListNode temp = A;

            //Find the starting point
            //1 2 3 4 5 6  B=2 , C =3 
            // 1 3 2 4 5 6 
            int i = 1;
            for (; i < B; i++)
            {
                reverse_Start_Previous = temp;
                temp = temp.next;
            }
            reverse_Start = temp;


            // find the ending point
            for (; i < C; i++)
            {
                temp = temp.next;

            }
            reverse_End = temp;

            //assign the end of the C point next to null
            ListNode next = reverse_End.next;
            reverse_End.next = null;

            // reverse the list
            reverse_Start = reverseAB(reverse_Start);

            //if there is a pervious of the reverse start and it is not null then 
            // do previous -> next points to the start of reverser_Start
            if (reverse_Start_Previous != null)
            {
                reverse_Start_Previous.next = reverse_Start;
            }
            // else add the reversed to the start this would be the case when the complete list is reversed
            else
            {
                A = reverse_Start;
            }

            // now we need to append the list after point C to the ending that we receieved from the reverse_Start
            temp = reverse_Start;

            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = next;
            
            //return the list
            return A; 
        }


        /// <summary>
        /// Reversing the linked list
        /// </summary>
        /// <param name="reverse_Start"></param>
        /// <returns></returns>
        private static ListNode reverseAB(ListNode reverse_Start)
        {
           ListNode prev = null;
           ListNode next = reverse_Start;
           ListNode current = reverse_Start;

            // 1 2 3 4 5 6 
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}
