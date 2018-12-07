using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeLibrary;
using ProjectEuler;

namespace PE_UnitTests
{
    [TestClass]
    public class Problem8Tests
    {
        [TestMethod]
        public void Constructor_Test()
        {
            var p8 = new Problem8();
            Assert.IsNotNull(p8);
        }
        
        [TestMethod]
        public void getSubstrings_Test()
        {
            // Arrange
            var p8 = new Problem8();
            Assert.IsNotNull(p8.subStrings);
            Assert.IsTrue(p8.subStrings.Length > 0);
            $"subStrings has {p8.subStrings.Length} elements".ToConsole();
            p8.subStrings.ToConsole();
        }

        [TestMethod]
        public void getScannableStrings_Test()
        {
            // Arrange
            var p8 = new Problem8();
            Assert.IsNotNull(p8.canBeScanned);
            Assert.IsTrue(p8.canBeScanned.Length > 0);
            $"canBeScanned has {p8.canBeScanned.Length} elements".ToConsole();
            p8.canBeScanned.ToConsole();
        }

        [TestMethod]
        public void DigitProduct_ExtensionMethod_Test()
        {
            string str = "1";
            Assert.IsTrue(str.DigitProduct() == 1);
            str = "12";
            Assert.IsTrue(str.DigitProduct() == 2);
            str = "123";
            Assert.IsTrue(str.DigitProduct() == 6);
            str = "1234";
            Assert.IsTrue(str.DigitProduct() == 24);
            str = "12340";
            Assert.IsTrue(str.DigitProduct() == 0);
            str = "12340567";
            Assert.IsTrue(str.DigitProduct() == 0);
        }

        [TestMethod]
        public void ToScanStrings_ExtensionMethod_Test()
        {
            string str = "12345678901234567890";
            str.ToConsole();
            string[] result = str.ToScanStrings(9);
            result.ToConsole();
            Assert.IsTrue(result.Length == 12);
        }

    }
}
