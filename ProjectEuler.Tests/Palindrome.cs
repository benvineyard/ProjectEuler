using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class Palindrome
    {
        [TestMethod]
        public void GetLargestFromProductOfTwoThreeDigitNumbers()
        {
            int question4 = ProjectEuler.Palindrome.GetLargestFromProductOfTwoThreeDigitNumbers();

            Assert.AreEqual(question4, 906609);
        }
    }
}
