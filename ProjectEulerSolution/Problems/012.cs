using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution.Problems
{
    class _012
    {
        public static int HighlyDivisibleTranglularNumber()
        {
            return 0;
        }
        public static int HighlyDivisibleTranglularNumberTesting()
        {
            int n, tNumber;
            List<int> factors;

            for (n = 1; true; n++)
            {
                tNumber = n * (n + 1) / 2;

                factors = new List<int>();
                int max = (int)Math.Sqrt(tNumber);
                for (int factor = 1; factor <= max; ++factor)
                {
                    if (tNumber % factor == 0)
                    {
                        factors.Add(factor);
                        if (factor != tNumber / factor)
                        {
                            factors.Add(tNumber / factor);
                        }
                    }
                }

                if (factors.Count > 500) break;
            }

            return tNumber;
        }
    }
}
