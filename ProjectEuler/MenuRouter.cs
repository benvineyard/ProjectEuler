using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// Utility class to appropriately route console based question requests to 
    /// the corresponding answer command execution.
    /// </summary>
    class MenuRouter
    {
        internal static void Route(short questionNumber)
        {
            switch (questionNumber)
            {
                case 1:
                    Console.WriteLine(string.Format("Problem #1 - Find the sum of all the multiples of 3 or 5 below 1000: {0}", Problem1.Answer()));
                    break;
                case 2:
                    Console.WriteLine(string.Format("Problem #2 - By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms: {0}", Problem2.EvenFibonacciNumbersSum()));
                    break;
                case 3:
                    Console.WriteLine(string.Format("Problem #3 - What is the largest prime factor of the number 600851475143: {0}", Problem3.GetLargestPrimeFactor()));
                    break;
                case 4:
                    Console.WriteLine(string.Format("Problem #4 - Find the largest palindrome made from the product of two 3-digit numbers: {0}", Palindrome.GetLargestFromProductOfTwoThreeDigitNumbers()));
                    break;
                default:
                    break;
            }
        }
    }
}
