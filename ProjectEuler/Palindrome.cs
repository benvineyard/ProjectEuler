using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Palindrome
    {
        /// <summary>
        /// Calculates the largest possible palindrome from the product of 
        /// two three digit numbers.
        /// </summary>
        /// <returns>The largest possible palindrome.</returns>
        public static int GetLargestFromProductOfTwoThreeDigitNumbers()
        {
            int largestProduct = 0;

            for (int x = 0; x < 1000; x++)
            {
                for (int y = 0; y < 1000; y++)
                {
                    int nextProduct = x * y;

                    if (nextProduct > largestProduct && IsPalindrome(nextProduct.ToString()))
                        largestProduct = nextProduct;
                }
            }

            return largestProduct;
        }

        /// <summary>
        /// Determines whether or not a provided string is a palindrome or not.
        /// </summary>
        /// <param name="stringToCheck">The provided string to check for palindromic conditions.</param>
        /// <returns>True if the provided string is a palindrome, otherwise false.</returns>
        private static bool IsPalindrome(string stringToCheck)
        {
            if (string.IsNullOrEmpty(stringToCheck))
                throw new ArgumentException("String cannot be null.");

            string reversed = new string(stringToCheck.ToCharArray().Reverse().ToArray());

            if (stringToCheck == reversed)
                return true;

            return false;
        }
    }
}
