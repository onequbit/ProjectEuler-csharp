using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectEuler;
using System;

namespace PE_UnitTests
{
    [TestClass]
    public class Problem6Tests
    {
        
        [TestMethod]
        public void VerifySummationFunctions()
        {
            // Arrange
            var unitUnderTest = new Problem6();
            int limit = 10;

            // Act
            var quickResult = unitUnderTest.QuickRangeSum(limit);
            var calcResult = unitUnderTest.CalcRangeSum(limit);

            // Assert
            Assert.AreEqual(quickResult, calcResult);
            $"quick: {quickResult}, calculated: {calcResult}".ToConsole();

            // Arrange
            limit = 100;

            // Act            
            quickResult = unitUnderTest.QuickRangeSum(limit);
            calcResult = unitUnderTest.CalcRangeSum(limit);

            // Assert
            Assert.AreEqual(quickResult, calcResult);
            $"quick: {quickResult}, calculated: {calcResult}".ToConsole();
        }

        [TestMethod]
        public void GetSquareSum_Test()
        {
            var p6 = new Problem6();
            var set = 1.RangeTo(10);
            var result = p6.GetSquareSum(set);
            Assert.IsTrue(result == 385);
        }

        [TestMethod]
        public void GetSumSquare_Test()
        {
            var p6 = new Problem6();
            var set = 1.RangeTo(10);
            var result = p6.GetSumSquare(set);
            Assert.IsTrue(result == 3025);
        }

        //[TestMethod]
        //public void CalcRangeSum_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var unitUnderTest = CreateProblem6();
        //    int limit = TODO;

        //    // Act
        //    var result = unitUnderTest.CalcRangeSum(
        //        limit);

        //    // Assert
        //    Assert.Fail();
        //}
    }
}
