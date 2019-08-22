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
            int maxSteps = 0;

            Console.WriteLine();

            for (int i = 0; i < 1000000; i++)
            {
                int steps = CollatzSequence(i);

                if (true)
                {

                }
            }

            return result;
        }

        private static int CollatzSequence(int n)
        {
            return n == 0 ? throw new ArgumentException() : (n == 1 ? 1 : 1 + (n % 2 == 0 ? CollatzSequence(n / 2) : CollatzSequence(3 * n + 1)));
        }
    }
}
