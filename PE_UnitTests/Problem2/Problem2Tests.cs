using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProjectEuler;
using System;

namespace PE_UnitTests
{
    [TestClass]
    public class Problem2Tests
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
        public void GetFibonacciSequence_StateUnderTest_ExpectedBehavior()
        {
            int maxValue = 4000000;
            
            $"Max Value: {maxValue}".ToConsole();
            var fib = new Problem2(maxValue).FibonacciSequence;
            fib.PrintLines("set");
            fib.SelectEvens().PrintLines("filtered");
            Assert.IsTrue(true);
        }
    }
}
