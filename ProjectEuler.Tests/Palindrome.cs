using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Palindrome
    {
        /// <summary>
        /// Test method to validate correctness of the Project Euler 
        /// #4 math problem: "Find the largest palindrome made from 
        /// the product of two 3-digit numbers."
        /// </summary>
        /// <see cref="https://projecteuler.net/problem=4"/>
        [TestMethod]
        public void GetLargestFromProductOfTwoThreeDigitNumbers()
        {
            int question4 = ProjectEuler.Palindrome.GetLargestFromProductOfTwoThreeDigitNumbers();

            Assert.AreEqual(question4, 906609);
        }
    }
}
