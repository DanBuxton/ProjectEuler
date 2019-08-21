using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution.Problems
{
    class _009
    {
        public static int SpecialPythagoreanTriplet()
        {
            int a = 0, b = 0, c = 0;
            bool hasFinished = false;

            for (a = 1; a < 1000 && !hasFinished; a++)
                for (b = a + 1; b < 1000 && !hasFinished; b++)
                {
                    c = 1000 - a - b;
                    double sumofsquares = Math.Pow(a, 2) + Math.Pow(b, 2);
                    if (sumofsquares == Math.Pow(c, 2)) hasFinished = true;
                }

            return (hasFinished ? a * b * c : 0);
        }
    }
}
