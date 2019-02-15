using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeLibrary;
using ProjectEuler;
using System;
using System.Linq;
using System.Collections.Generic;

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
            int getDigit = 49;
            $"number 0: {p.GetNumber(0)}".ToConsole();
            int digit = p.GetNumber(0).GetDigit(getDigit);
            $"digit {getDigit}: expected {expected}, got {digit}".ToConsole();
            Assert.AreEqual(digit, expected, "digits are not equal");

            expected = 6;
            getDigit = 48;
            $"number 1: {p.GetNumber(1)}".ToConsole();
            digit = p.GetNumber(1).GetDigit(getDigit);
            $"digit {getDigit}: expected {expected}, got {digit}".ToConsole();
            Assert.AreEqual(digit, expected, "digits are not equal");

            expected = 9;
            getDigit = 1;
            $"number 99: {p.GetNumber(99)}".ToConsole();
            digit = p.GetNumber(99).GetDigit(getDigit);
            $"digit {getDigit}: expected {expected}, got {digit}".ToConsole();
            Assert.AreEqual(digit, expected, "digits are not equal");
        }

        [TestMethod]
        public void ToDigitList_Test()
        {
            string number = "12345";
            number.ToDigitList().ToConsole();

        }

        [TestMethod]
        public void ToNumberString_Test()
        {            
            List<int> digitList = new List<int> { 5, 4, 3, 2, 1 };
            digitList.ToNumberString().ToConsole();
        }

        [TestMethod]
        public void AddDigits_Test()
        {
            for (int i = 0; i < 50; i++)
            {
                int number1 = RndLib.RandomInt(0, int.MaxValue / 8);
                int number2 = RndLib.RandomInt(0, int.MaxValue / 8);
                int sum = number1 + number2;
                $"ints: {number1} + {number2} = {sum}".ToConsole();

                string numStr1 = number1.ToString();
                string numStr2 = number2.ToString();
                string sumStr = Problem13.AddDigits(numStr1, numStr2);
                $"strings: {numStr1} + {numStr2} = {sumStr}".ToConsole();

                Assert.AreEqual(sumStr, $"{sum}", $"{sumStr} != {sum}!!!");
                
            }
        }
            //[TestMethod]
            //public void AppendArrays_Test()
            //{
            //    int[] array1 = new int[] { 1, 2, 3 };
            //    int[] array2 = new int[] { 6, 7 };
            //    array1.ToStringList().ToConsole();
            //    array2.ToStringList().ToConsole();
            //    "{ 1, 2, 3 } + { 6, 7 } = ".ToConsole();
            //    array1.Append(array2).ToStringList().ToConsole();
            //    "".ToConsole();

            //    array1 = new int[] { 1, 2, 3, 4, 5 };
            //    array2 = new int[] { 6, 7, 8, 9 };
            //    array1.ToStringList().ToConsole();
            //    array2.ToStringList().ToConsole();
            //    "{ 1, 2, 3, 4, 5 } + { 6, 7, 8, 9 } = ".ToConsole();
            //    array1.Append(array2).ToStringList().ToConsole();
            //    "".ToConsole();
            //}

            //[TestMethod]
            //public void NormalizedArrays_Test()
            //{
            //    int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            //    int[] array2 = new int[] { 6, 7, 8, 9 };
            //    array1.ToStringList().ToConsole();
            //    array2.ToStringList().ToConsole();
            //    0.NormalizeArrays(ref array1, ref array2);
            //    array1.ToStringList().ToConsole();
            //    array2.ToStringList().ToConsole();
            //    "".ToConsole();

            //    array1 = new int[] { 1, 2 };
            //    array2 = new int[] { 6, 7, 8 };
            //    array1.ToStringList().ToConsole();
            //    array2.ToStringList().ToConsole();
            //    0.NormalizeArrays(ref array1, ref array2);
            //    array1.ToStringList().ToConsole();
            //    array2.ToStringList().ToConsole();
            //    "".ToConsole();
            //}

        [TestMethod]
        public void NormalizeNumber_Test()
        {
            string num1 = "1234";
            string num2 = "123";
            Problem13.NormalizeNumbers(ref num1, ref num2);
            $"num1: {num1}, num2: {num2}".ToConsole();

            num1 = "1234";
            num2 = "123456789";
            Problem13.NormalizeNumbers(ref num1, ref num2);
            $"num1: {num1}, num2: {num2}".ToConsole();
        }


    }
}
