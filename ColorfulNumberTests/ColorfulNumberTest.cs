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
    }
}
