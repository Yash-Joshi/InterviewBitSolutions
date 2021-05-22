using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Trees
{
    public class BalancedTree
    {
       
        public static List<int> inorderTraversal(TreeNode A)
        {
            Stack<TreeNode> st = new Stack<TreeNode>();
            List<int> ret = new List<int>();

            TreeNode curr = A;

            while (curr != null || st.Count != 0)
            {
                if (curr != null)
                {
                    st.Push(curr);
                    curr = curr.left;
                }
                if (curr == null)
                {
                    TreeNode temp = st.Pop();
                    ret.Add(temp.val);
                    curr = temp.right;

                }
            }

            return ret;
        }
    }
}
