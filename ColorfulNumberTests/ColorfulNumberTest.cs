using System;
using ColorfulNumberLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorfulNumberLibraryTests
{
    [TestClass]
    public class ColorfulNumberTest
    {
        [TestMethod]
        public void TestIsColorful()
        {
            int number = 3245;

            ColorfulNumber colorfulNumber = new ColorfulNumber();

            Boolean isColorful = colorfulNumber.IsColorful(number);

            Assert.IsTrue(isColorful);
        }

        [TestMethod]
        public void TestIsNotColorful()
        {
            int number = 326;

            Boolean isColorful = new ColorfulNumber().IsColorful(number);

            Assert.IsFalse(isColorful);
        }

        [TestMethod]
        public void TestIsNotColorfulWithZero()
        {
            int number = 708;

            Boolean isColorful = new ColorfulNumber().IsColorful(number);

            Assert.IsFalse(isColorful);
        }

        [TestMethod]
        public void TestIsNotColorfulWithOne()
        {
            int number = 317;

            Boolean isColorful = new ColorfulNumber().IsColorful(number);

            Assert.IsFalse(isColorful);
        }

        [TestMethod]
        public void TestIsNotColorfulWithMoreThanTenDigits()
        {
            long number = 98765432297;

            Boolean isColorful = new ColorfulNumber().IsColorful(number);

            Assert.IsFalse(isColorful);
        }

        [TestMethod]
        public void TestIsNotColorfulWithDuplicates()
        {
            int number = 737;

            Boolean isColorful = new ColorfulNumber().IsColorful(number);

            Assert.IsFalse(isColorful);
        }
    }
}
