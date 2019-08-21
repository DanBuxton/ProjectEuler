using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution.Problems
{
    class _010
    {
        public static long SumOfPrimes()
        {
            int max = 2000000, i;
            long sum = 0;
            for (i = 2; i < max; i++)
            {
                if (i.IsPrime())
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
