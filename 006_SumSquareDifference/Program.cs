using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The difference is: { Difference(100) }");
        }

        public static int Difference(int x)
        {
            return SquareOfSumNumbers(x) - SumOfSquareNumbers(x);
        }

        private static int SumOfSquareNumbers(int x)
        {
            int sum = 0;

            for (int i = 1; i <= x; i++)
            {
                sum += (int)Math.Pow(i, 2);
            }

            return sum;
        }

        private static int SquareOfSumNumbers(int x)
        {
            int sum = 0;

            for (int i = 1; i <= x; i++)
            {
                sum += i;
            }

            return (int)Math.Pow(sum, 2);
        }
    }
}
