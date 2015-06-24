using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Multiples
    {
        /// <summary>
        /// Test method to validate correctness of the Project Euler 
        /// #1 math problem: "Find the sum of all the multiples of 3 or 5 below 1000."
        /// </summary>
        /// <see cref="https://projecteuler.net/problem=1"/>
        [TestMethod]
        public void CalculateSum()
        {
            int question1 = ProjectEuler.Multiples.CalculateSum(3, 5, 1000);

            Assert.AreEqual(question1, 233168);
        }

        /// <summary>
        /// Test method to validate correctness of the Project Euler 
        /// #5 math problem: "What is the smallest positive number 
        /// that is evenly divisible by all of the numbers from 1 to 20?"
        /// </summary>
        /// <see cref="https://projecteuler.net/problem=5"/>
        [TestMethod]
        public void SmallestEvenlyDivisibleByAllFromXtoY()
        {
            int question5 = ProjectEuler.Multiples.SmallestEvenlyDivisibleByAllFromXtoY(1, 20);

            Assert.AreEqual(question5, 232792560);
        }
    }
}
