using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.LinkedList
{
    public class SwapPairs
    {
        public static ListNode swap(ListNode A)
        {
            ListNode temp = A;

            while (temp != null && temp.next != null)
            {
                int t = temp.val;
                temp.val = temp.next.val;
                temp.next.val = t;
                temp = temp.next.next;
            }

            return A;        
        }
    }
}
