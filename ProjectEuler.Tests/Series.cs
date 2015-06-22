using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Series
    {
        [TestMethod]
        public void DifferenceSumOfSquaresAndSquaredSum()
        {
            var question6 = ProjectEuler.Series.DifferenceSumOfSquaresAndSquaredSum(1, 100);

            Assert.AreEqual(question6, 25164150);
        }
    }
}
