using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Stacks
{
    public class RedundantBraces
    {  
        public static int braces(string A)
        {
            // (a/b)+(b*d)+(a*a)+a  === ( O ) O (O) O (O) O 
            Stack<char> st = new Stack<char>();
            char[] charArray = A.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '(')
                {
                    st.Push(charArray[i]);
                }
                if (charArray[i] == '/' || charArray[i] == '*' || charArray[i] == '-' || charArray[i] == '+')
                {
                    st.Push('O');
                }
                // (a+ (a+b)) [ ( O ( O ) )] || ((a+b)) --> [ ( ( + ) ) ]
                if (charArray[i] == ')')
                {
                    char tempCheck = st.Peek();
                    int count = 0;
                    while (tempCheck != '(')
                    {
                        st.Pop();
                        tempCheck = st.Peek();
                        count++;
                    }
                    if (tempCheck == '(' && count == 0)
                    {
                        return 1;
                    }

                    if (tempCheck == '(' && count != 0)
                    {
                        st.Pop();
                    }
                }


            }

            while(st.Count != 0)
            {
                if (st.Pop() != 'O')
                {
                    return 1;
                }
            }
            if (st.Count == 0 || (st.Peek() == 'O' && st.Count == 1))
                return 0;
            else
                return 1;
            

        }
    }
}
