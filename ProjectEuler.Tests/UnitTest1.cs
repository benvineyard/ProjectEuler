using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPythagoreanTripletProductForProvidedSum()
        {
            var question9 = Pythagorean.GetPythagoreanTripletProductForProvidedSum(1000);

            Assert.AreEqual(question9, 31875000);
        }
    }
}
