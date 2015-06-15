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
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Problem #1 - Find the sum of all the multiples of 3 or 5 below 1000: "); 
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Multiples.CalculateSum(3, 5, 1000));
                    Console.WriteLine();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Problem #2 - By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Fibonacci.EvenFibonacciNumbersSum(4000000));
                    Console.WriteLine();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Problem #3 - What is the largest prime factor of the number 600851475143: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Prime.GetLargestPrimeFactor());
                    Console.WriteLine();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Problem #4 - Find the largest palindrome made from the product of two 3-digit numbers: "); 
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Palindrome.GetLargestFromProductOfTwoThreeDigitNumbers());
                    Console.WriteLine();
                    break;
                default:
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
