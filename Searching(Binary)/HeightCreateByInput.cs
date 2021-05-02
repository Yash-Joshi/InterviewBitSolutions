using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Searching
{
    public class HeightCreateByInput
    {
        public static int solve(int A)
        {

            
            int d = Math.Abs(((1 * 1 ) - (4 * A * 2)));
            int p = Convert.ToInt32(Math.Sqrt(d));
            if (p > 0)
            {
                d = (-1 + p) / 2;
                return d;
            }
            return 0;

        }
    
    }
}
