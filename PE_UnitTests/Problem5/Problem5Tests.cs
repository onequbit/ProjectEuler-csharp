using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectEuler;
using System;
using System.Collections.Generic;

namespace PE_UnitTests
{
    [TestClass]
    public class Problem5Tests
    {

        [TestMethod]
        public void GetPrimesUpTo_StateUnderTest_ExpectedBehavior()
        {
            // Arrange                        
            // Act
            // Assert
            Assert.IsTrue(new Problem5().GetPrimesUpTo(10).Count == 4);
            Assert.IsTrue(new Problem5().GetPrimesUpTo(20).Count == 8);
            Assert.IsTrue(new Problem5().GetPrimesUpTo(30).Count == 10);

        }

        [TestMethod]
        public void GetInnerPrimePowersUpTo_StateUnderTest_ExpectedBehavior()
        {
            // Arrange            
            // Act
            // Assert
            var ten = new Problem5().GetInnerPrimePowersUpTo(10);
            var thirty = new Problem5().GetInnerPrimePowersUpTo(30);
            var fifty = new Problem5().GetInnerPrimePowersUpTo(50);
            Assert.IsTrue(ten.Count == 2);
            "10:".ToConsole();
            ten.ToArray().Join(",").ToConsole();
            Assert.IsTrue(thirty.Count == 3);
            "30:".ToConsole();
            thirty.ToArray().Join(",").ToConsole();
            Assert.IsTrue(fifty.Count == 4);
            "50:".ToConsole();
            fifty.ToArray().Join(",").ToConsole();
        }

        [TestMethod]
        public void RangeTo_ExtensionMethodTest_ExpectedBehavior()
        {
            var a1 = 1.RangeTo(10);            
            Assert.IsTrue(a1.Count == 10);
            a1.ToConsole();

            var a2 = 10.RangeTo(20);
            Assert.IsTrue(a2.Count == 11);
            a2.ToConsole();

            var a3 = 10.RangeTo(1);
            Assert.IsTrue(a1.Count == 10);
            a3.ToConsole();

            var a4 = 10.RangeTo(-9);
            Assert.IsTrue(a4.Count == 20);
            a4.ToConsole();

            var a5 = (-5).RangeTo(5);
            Assert.IsTrue(a5.Count == 11);
            a5.ToConsole();


        }
    }
}
