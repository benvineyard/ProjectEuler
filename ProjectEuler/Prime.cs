using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// Utility class to answer question #3 on projecteuler.net.
    /// The question is "What is the largest prime factor of the number 600851475143?"
    /// <see cref="projecteuler.net/problem=3"/>
    /// </summary>
    public class Prime
    {
        public static long GetLargestPrimeFactor(long numberToBeFactored = 600851475143)
        {
            int lastPrimeFactor = 0;

            for (int i = 3; i <= Math.Sqrt(numberToBeFactored); i+=2)
                if (IsPrimeNumber(i) && numberToBeFactored % i == 0)
                    lastPrimeFactor = i;    

            return lastPrimeFactor;
        }

        private static bool IsPrimeNumber(long number)
        {
            if (number % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(number); i+=2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
