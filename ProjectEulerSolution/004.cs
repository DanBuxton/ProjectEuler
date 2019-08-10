using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolution
{
    class _004
    {
        public static int LargestThreeDigitPalindrome()
        {
            int largestNumber = 0;
            int number = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    number = i * j;
                    if (number > largestNumber && IsPalindromicNumber(number.ToString()))
                    {
                        largestNumber = number;
                    }
                }
            }
            return largestNumber;
        }

        static bool IsPalindromicNumber(string number)
        {
            return string.Equals(number, new String(number.Reverse().ToArray()));
        }
    }
}
