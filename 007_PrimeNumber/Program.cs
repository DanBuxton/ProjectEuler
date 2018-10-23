using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_PrimeNumber
{
    public static class Extentions
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NthPrimeNumber(n: 1001));
        }

        public static int NthPrimeNumber(int n)
        {
            int numPrimes = 1, num = 2;

            while (numPrimes < n)
            {
                num++;

                if (num.IsPrime())
                {
                    numPrimes++;
                }
            }

            return num;
        }

        #region isPrime
        /// <summary>
        /// Decides if a number is prime or not. 
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Returns true when the number is prime</returns>
        public static bool isPrime(int num)
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
        #endregion
    }
}
