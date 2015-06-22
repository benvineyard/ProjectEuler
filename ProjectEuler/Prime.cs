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

        /// <summary>
        /// Retrieves the nth prime number where n is <paramref name="n"/>
        /// </summary>
        /// <param name="n">The position index to search prime for.</param>
        /// <returns>A prime number in the nth position.</returns>
        public static long GetNthPrime(long n)
        {
            long count = 0;

            for (int i = 2; i < int.MaxValue; i++)
            {
                if (IsPrimeNumber(i))
                {
                    count += 1;

                    if (count == n)
                        return i;
                }
            }

            return 0;
        }

        private static bool IsPrimeNumber(long candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}
