using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Recursion
{
    public class TwoBoxCombination
    {
        // We have N (user input boxes) 
        // we can either insert 1 or 2 and you need to find all the possible combination of the numbers


        // N= 2
        // 1,1,
        //1,2
        //2,1
        //2,2
        public static int PossibleCombinations(int P, int N)
        {
            if (P == N)
            {
                return 1; 
            }

            int result = 0;

            for (int i = 0; i <= N; i++)
            {
                result += PossibleCombinations(i + 1, N);
            }
            return result;

        }

       
    }
}
