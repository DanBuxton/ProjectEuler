using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    class _002
    {
        public static int SumOfEvenFibonacciNumbers()
        {

            int sum = 0, num = 1, prev = 0, temp = 0;
            do
            {
                temp = num;
                num += prev;
                prev = temp;

                if (num % 2 == 0)
                {
                    sum += num;
                }
            } while (num < 4000000);

            return sum;
        }
    }
}
