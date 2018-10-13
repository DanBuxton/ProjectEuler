using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NthPrimeNumber(n: 1001));
        }

        public static int NthPrimeNumber(int n)
        {
            int numPrimes = 1, numm = 2;

            while (numPrimes < n)
            {
                numm++;

                if (isPrime(numm))
                {
                    numPrimes++;
                }
            }

            return numm;
        }

        public static bool isPrime(int numm)
        {
            if (numm <= 1)
            {
                return false;
            }

            if (numm == 2)
            {
                return true;
            }

            if (numm % 2 == 0)
            {
                return false;
            }

            int counter = 3;

            while ((counter * counter) <= numm)
            {
                if (numm % counter == 0)
                {
                    return false;
                }
                else
                {
                    counter += 2;
                }
            }

            return true;
        }
    }
}
