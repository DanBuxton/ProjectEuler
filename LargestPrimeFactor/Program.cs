using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestPrimeFactorOf(600851475143));
        }

        private static int LargestPrimeFactorOf(long n)
        {
            do
            {
                long p = smallestFactor(n);

                if (p < n)
                { n /= p; }
                else
                    return (int)n;
            } while (true);
        }

        private static long smallestFactor(long n)
        {
            if (n <= 1)
                throw new Exception();

            for (long i = 2, end = (long)Math.Sqrt(n); i <= end; i++)
            {
                if (n % i == 0)
                    return i;
            }

            return n;  // n itself is prime
        }
    }
}
