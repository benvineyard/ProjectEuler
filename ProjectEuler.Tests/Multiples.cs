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
    }
}
