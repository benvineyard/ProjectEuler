using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Prime
    {
        [TestMethod]
        public void GetLargestPrimeFactor()
        {
            long question3 = ProjectEuler.Prime.GetLargestPrimeFactor(600851475143);

            Assert.AreEqual(question3, 6857);
        }

        [TestMethod]
        public void Get10001thPrime()
        {
            long question7 = ProjectEuler.Prime.GetNthPrime(10001);

            Assert.AreEqual(question7, 104743);
        }
    }
}
