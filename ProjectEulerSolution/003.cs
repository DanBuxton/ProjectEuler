using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    class _003
    {
        public static int LargestPrimeFactor()
        {
            long n = 600851475143, p;

            while (true)
            {
                p = SmallestFactor(n);

                if (p < n) n /= p;
                else return (int)n;
            }
        }

        private static long SmallestFactor(long n)
        {
            if (n <= 1)
                throw new Exception();

            for (long i = 2, end = (long)Math.Sqrt(n); i <= end; i++)
            {
                if (n % i == 0)
                    return i;
            }

            return n;  // n itself is prime
        }
    }
}
