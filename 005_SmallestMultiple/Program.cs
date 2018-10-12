using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The smallest common multiple of 1-20: { SmallestMultiple(maxDivisible: 20) }");
        }

        public static int SmallestMultiple(int maxDivisible)
        {
            int i = maxDivisible;

            while (i % 2 != 0 || i % 3 != 0 || i % 4 != 0 || i % 5 != 0 ||
                i % 6 != 0 || i % 7 != 0 || i % 8 != 0 || i % 9 != 0 ||
                i % 10 != 0 || i % 11 != 0 || i % 12 != 0 || i % 13 != 0 ||
                i % 14 != 0 || i % 15 != 0 || i % 16 != 0 || i % 17 != 0 ||
                i % 18 != 0 || i % 19 != 0 || i % 20 != 0)
            {
                i += maxDivisible;
            }

            return i;
        }
    }
}
