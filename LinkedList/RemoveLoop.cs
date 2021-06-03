using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.LinkedList
{
    public class RemoveLoop
    {
        public static ListNode solve(ListNode A)
        {

            // Create a Dictionary for visited node
            // if seen again then that is the breaking condition 

            ListNode temp = A;

            Dictionary<ListNode, int> find = new Dictionary<ListNode, int>();

            while (!find.ContainsKey(temp.next))
            {
                find.Add(temp, temp.val);
                temp = temp.next;
            }

            temp.next = null;

            return A;
        }
    }
}
