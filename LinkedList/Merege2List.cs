using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.LinkedList
{
    public class Merege2List
    {
        public static ListNode mergeTwoLists(ListNode A, ListNode B)
        {

            // 5->7->11->12
            // 4->6->8->13->14
            // o/p 4->5->6->7->8->11->12->13->14


            ListNode first = A;
            ListNode second = B;
            ListNode final = null;

            if (A.val <= B.val)
            {
                final = first;
                first = first.next;
                final.next = null;

            }
            else
            {
                final = second;
                second = second.next;
                final.next = null;

            }

            ListNode temp = final;
            while (first != null && second != null)
            {
                if (first.val <= second.val)
                {
                    temp.next = first;
                    first = first.next;
                    temp = temp.next;
                    temp.next = null;
                }
                else
                {
                    temp.next = second;
                    second = second.next;
                    temp = temp.next;
                    temp.next = null;

                }
            }

            if (first == null && second != null)
            {
                temp.next = second;
                return final;
            }
            else if (first != null && second == null)
            {
                temp.next = first;
                return final;
            }
            return final;
        }
    }
}
