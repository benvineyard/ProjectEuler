using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Fibonacci
    {
        /// <summary>
        /// Test method to validate correctness of the Project Euler 
        /// #2 math problem: "By considering the terms in the Fibonacci 
        /// sequence whose values do not exceed four million, find the 
        /// sum of the even-valued terms."
        /// </summary>
        /// <see cref="https://projecteuler.net/problem=2"/>
        [TestMethod]
        public void EvenFibonacciNumbersSum()
        {
            int question2 = ProjectEuler.Fibonacci.EvenFibonacciNumbersSum(4000000);

            Assert.AreEqual(question2, 4613732);
        }
    }
}
