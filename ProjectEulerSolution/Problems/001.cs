using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution.Problems
{
    class _001
    {
        public static int SumOfMultiples()
        {
            int result = 0, i;

            for (i = 3; i < 1000; i++)
                if ((i % 3) == 0 || (i % 5) == 0)
                    result += i;

            return result;
        }
    }
}
