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
                case 5:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Problem #5 - What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Multiples.SmallestEvenlyDivisibleByAllFromXtoY(1, 20));
                    Console.WriteLine();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Problem #6 - Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Series.DifferenceSumOfSquaresAndSquaredSum(1, 100));
                    Console.WriteLine();
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Problem #7 - What is the 10 001st prime number: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Prime.GetNthPrime(10001));
                    Console.WriteLine();
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Problem #8 - Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Series.AdjacentProductOfKnownSeries(13));
                    Console.WriteLine();
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Problem #9 - There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Pythagorean.GetPythagoreanTripletProductForProvidedSum(1000));
                    Console.WriteLine();
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Problem #10 - Find the sum of all the primes below two million.: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Prime.GetSumOfPrimes(2000000));
                    Console.WriteLine();
                    break;
                default:
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
