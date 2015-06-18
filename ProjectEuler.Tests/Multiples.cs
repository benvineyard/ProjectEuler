using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Multiples
    {
        [TestMethod]
        public void CalculateSum()
        {
            int question1 = ProjectEuler.Multiples.CalculateSum(3, 5, 1000);

            Assert.AreEqual(question1, 233168);
        }

        [TestMethod]
        public void SmallestEvenlyDivisibleByAllFromXtoY()
        {
            int question5 = ProjectEuler.Multiples.SmallestEvenlyDivisibleByAllFromXtoY(1, 20);

            Assert.AreEqual(question5, 232792560);
        }
    }
}
