using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    static class Extensions
    {
        public static bool IsPrime(this int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else if (num == 2)
            {
                return true;
            }

            if (num % 2 == 0)
            {
                return false;
            }

            int counter = 3;

            while ((counter * counter) <= num)
            {
                if (num % counter == 0)
                {
                    return false;
                }
                else
                {
                    // A prime number always odd except for 2. 
                    counter += 2;
                }
            }

            return true;
        }

        public static int SumOfMultiples(int below, params int[] multiplesOf)
        {
            int result = 0;

            for (int j = 0; j < 1000; j++)
            {
                if ((j % 3) == 0 || (j % 5) == 0)
                {
                    result += j;
                }
            }

            return result;
        }
    }
}
