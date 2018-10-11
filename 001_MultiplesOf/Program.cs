using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_MultiplesOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfMultiples(1000, 3, 5));
        }

        private static int SumOfMultiples(int below, params int[] multiplesOf)
        {
            int result = 0;

            for (int j = 0; j < below; j++)
            {
                for (int i = 0; i < multiplesOf.Count(); i++)
                {
                    if (j % multiplesOf[i] == 0)
                    {
                        result += j;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
