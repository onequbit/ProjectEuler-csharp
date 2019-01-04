using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeLibrary;
using ProjectEuler;
using System;
using System.Linq;

namespace PE_UnitTests.Eleven_to_20
{
    [TestClass]
    public class Problem13Tests
    {
        
        [TestMethod]
        public void _numberStrings_Test()
        {
            // Arrange
            var p = new Problem13();
            string first_expected = "37107287533902102798797998220837590246510135740250";
            string last_expected = "53503534226472524250874054075591789781264330331690";

            // Act
            string first_number = p.GetNumber(0);
            string last_number = p.GetNumber(99);

            // Assert
            Assert.IsTrue(first_number.Equals(first_expected), "strings are not equal");
            Assert.IsTrue(last_number.Equals(last_expected), "strings are not equal");
        }

        [TestMethod]
        public void GetDigit_Tests()
        {
            var p = new Problem13();
            int expected = 3;
            int digit = p.GetNumber(0).GetDigit(49);
            $"expected {expected}, got {digit}".ToConsole();
            Assert.AreEqual(digit, expected, "digits are not equal");

            expected = 6;
            digit = p.GetNumber(1).GetDigit(48);
            $"expected {expected}, got {digit}".ToConsole();
            Assert.AreEqual(digit, expected, "digits are not equal");

            expected = 9;
            digit = p.GetNumber(99).GetDigit(1);
            $"expected {expected}, got {digit}".ToConsole();
            Assert.AreEqual(digit, expected, "digits are not equal");
        }

        [TestMethod]
        public void ToIntGenerator_Test()
        {
            string numberString = "123456789";
            int[] numbers = numberString.ToIntGenerator().ToArray();
            numbers.ToConsole();
            $"{numbers[0]}".ToConsole();                
            $"{numbers[2]}".ToConsole();
        }

    }
}
