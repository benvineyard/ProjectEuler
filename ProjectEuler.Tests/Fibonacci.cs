using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Fibonacci
    {
        [TestMethod]
        public void EvenFibonacciNumbersSum()
        {
            int question2 = ProjectEuler.Fibonacci.EvenFibonacciNumbersSum(4000000);

            Assert.AreEqual(question2, 4613732);
        }
    }
}
