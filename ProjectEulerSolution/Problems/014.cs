using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution.Problems
{
    class _014
    {
        public static int CollatzSequenceLongestChain()
        {
            int result = 0;
            long maxSteps = 0;

            Console.WriteLine();

            for (int i = 1; i < 1000000; i++)
            {
                long steps = CollatzSequence(i);

                if (steps > maxSteps)
                {
                    maxSteps = steps;
                    result = i;
                }
            }

            return result;
        }

        private static int CollatzSequence(long n)
        {
            return n == 0 ? throw new ArgumentException() : (n == 1 ? 1 : 1 + (n % 2 == 0 ? CollatzSequence(n / 2) : CollatzSequence(3 * n + 1)));
        }
    }
}
