using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    class _001
    {
        public static int SumOfMultiples()
        {

            return Extensions.SumOfMultiples(1000, 3, 5);
            //int result = 0, i;

            //for (i = 0; i < 1000; i++)
            //{
            //    if ((i % 3) == 0 || (i % 5) == 0)
            //    {
            //        result += i;
            //    }
            //}

            //return result;
        }
    }
}
