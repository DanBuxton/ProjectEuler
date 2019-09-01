using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution.Problems
{
    class _016
    {
        public static int SumOfDigitsFromPower()
        {
            int sum = 0;
            BigInteger num = (BigInteger)Math.Pow(2, 1000);
            var numbers = num.ToString().Select(char.GetNumericValue);

            foreach (int n in numbers) sum += n;

            return sum;
        }
    }
}
