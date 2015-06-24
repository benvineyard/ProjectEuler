using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Series
    {
        /// <summary>
        /// Test method to validate correctness of the Project Euler 
        /// #6 math problem: "Find the difference between the sum 
        /// of the squares of the first one hundred natural numbers 
        /// and the square of the sum."
        /// </summary>
        /// <see cref="https://projecteuler.net/problem=6"/>
        [TestMethod]
        public void DifferenceSumOfSquaresAndSquaredSum()
        {
            var question6 = ProjectEuler.Series.DifferenceSumOfSquaresAndSquaredSum(1, 100);

            Assert.AreEqual(question6, 25164150);
        }

        /// <summary>
        /// Test method to validate correctness of the Project Euler 
        /// #8 math problem: "Find the thirteen adjacent digits in 
        /// the 1000-digit number that have the greatest product. 
        /// What is the value of this product?"
        /// </summary>
        /// <see cref="https://projecteuler.net/problem=8"/>
        [TestMethod]
        public void AdjacentProductOfKnownSeries()
        {
            var question8 = ProjectEuler.Series.AdjacentProductOfKnownSeries(13);

            Assert.AreEqual(question8, 23514624000);
        }
    }
}
