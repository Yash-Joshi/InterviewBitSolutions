using System;
using System.Collections.Generic;
using System.Text;

namespace Scaler.Recursion
{
    public class Pow
    {
        // x^y using recursion

        public static int Powee(int Base, int Power)
        {
            if (Power == 0)
                return 1;

            return Base * Powee(Base, Power - 1);
        }
    }
}
