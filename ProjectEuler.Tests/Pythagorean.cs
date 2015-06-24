using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Pythagorean
    {
        /// <summary>
        /// Test method to validate correctness of the Project Euler 
        /// #9 math problem: "There exists exactly one Pythagorean 
        /// triplet for which a + b + c = 1000.  Find the product abc."
        /// </summary>
        /// <see cref="https://projecteuler.net/problem=9"/>
        [TestMethod]
        public void GetPythagoreanTripletProductForProvidedSum()
        {
            var question9 = ProjectEuler.Pythagorean.GetPythagoreanTripletProductForProvidedSum(1000);

            Assert.AreEqual(question9, 31875000);
        }
    }
}
