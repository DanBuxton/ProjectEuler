using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    class _006
    {
        public static double SumSquareDifference()
        {
            double sumOfSquare = 0;
            double squareOfSum = 0;
            for (int i = 0; i <= 100; i++)
            {
                sumOfSquare += Math.Pow(i, 2);
                squareOfSum += i;
            }
            return (Math.Pow(squareOfSum, 2) - sumOfSquare);
        }
    }
}
