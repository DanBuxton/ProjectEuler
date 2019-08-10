using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    class _010
    {
        public static long SumOfPrimes()
        {
            /*
             * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
             * 
             * Find the sum of all the primes below two million.
             */

            var binLiteral = 1111_1111;

            int max = 2000000, i = 0;
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
