using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Prime
    {
        /// <summary>
        /// Test method to validate correctness of the Project Euler 
        /// #3 math problem: "What is the largest prime factor of the number 600851475143?"
        /// </summary>
        /// <see cref="https://projecteuler.net/problem=3"/>
        [TestMethod]
        public void GetLargestPrimeFactor()
        {
            long question3 = ProjectEuler.Prime.GetLargestPrimeFactor(600851475143);

            Assert.AreEqual(question3, 6857);
        }

        /// <summary>
        /// Test method to validate correctness of the Project Euler 
        /// #7 math problem: "What is the 10 001st prime number?"
        /// </summary>
        /// <see cref="https://projecteuler.net/problem=7"/>
        [TestMethod]
        public void Get10001thPrime()
        {
            long question7 = ProjectEuler.Prime.GetNthPrime(10001);

            Assert.AreEqual(question7, 104743);
        }

        /// <summary>
        /// Test method to validate correctness of the Project Euler 
        /// #10 math problem: "Find the sum of all the primes below two million."
        /// </summary>
        /// <see cref="https://projecteuler.net/problem=10"/>
        [TestMethod]
        public void GetSumOfAllPrimesBelowTwoMillion()
        {
            long question10 = ProjectEuler.Prime.GetSumOfPrimes(2000000);

            Assert.AreEqual(question10, 142913828922);
        }
    }
}
