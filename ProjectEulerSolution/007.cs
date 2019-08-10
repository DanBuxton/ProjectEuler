using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    class _007
    {
        public static int NthPrimeNumber()
        {
            int numPrimes = 1, num = 2, n = 10001;

            while (numPrimes < n)
            {
                num++;

                if (num.IsPrime())
                {
                    numPrimes++;
                }
            }

            return num;
        }
    }
}
