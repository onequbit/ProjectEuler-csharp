using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectEuler;
using System;

namespace PE_UnitTests
{
    [TestClass]
    public class Problem1Tests
    {
        private MockRepository mockRepository;
        
        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);            
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.mockRepository.VerifyAll();
        }
        
        [TestMethod]
        public void DoListBelow_StateUnderTest_ExpectedBehavior()
        {
            // Arrange/Act
            var unitUnderTest = new Problem1(10);            
            
            // Assert
            Assert.IsTrue(unitUnderTest.Count == 4,
                $"4 expected, {unitUnderTest.Count} returned");
            Assert.IsTrue(unitUnderTest.Sum == 23,
                $"23 expected, {unitUnderTest.Sum} returned");

            // Arrange/Act
            unitUnderTest = new Problem1(20);

            // Assert
            Assert.IsTrue(unitUnderTest.Count == 8,
                $"8 expected, {unitUnderTest.Count} returned");
            Assert.IsTrue(unitUnderTest.Sum == 78,
                $"78 expected, {unitUnderTest.Sum} returned");

        }
        

    }
}
