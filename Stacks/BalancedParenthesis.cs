using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Stacks
{
    public class BalancedParenthesis
    {
        public static int solve(string A)
        {
            //Return 1 if balanced. 

            char[] braces = A.ToCharArray();

            Dictionary<char, char> rule = new Dictionary<char, char>
            {
                {'{', '}'},
                {'[', ']'},
                {'(', ')'},
            };

            Stack<char> checkStack = new Stack<char>();
            bool pushed = false;
            foreach (char bracket in braces)
            {
                if (rule.ContainsKey(bracket))
                {
                    checkStack.Push(bracket);
                    pushed = true;
                }
                else
                {
                    if (checkStack.Count > 0)
                    {
                        char i = checkStack.Peek();
                        if (rule[i] == bracket)
                        {
                            checkStack.Pop();
                            continue;
                        }
                    }
                }
            }

            if (checkStack.Count > 0 || pushed == false)
            {
                return 0;
            }
            else
                return 1;

        }
    }
}
