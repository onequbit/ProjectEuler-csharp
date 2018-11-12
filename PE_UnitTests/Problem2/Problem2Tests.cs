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

        //private Problem2 CreateProblem2()
        //{
        //    return new Problem2(10);
        //}

        [TestMethod]
        public void GetFibonacciSequence_StateUnderTest_ExpectedBehavior()
        {
            int maxValue = 4000000;
            //for (int i = 0; i < maxValue; i++)
            //{
            //    $"Max Value: {i}".ToConsole();
            //    var fib = new Problem2(i).FibonacciSequence;
            //    fib.PrintLines("set");
            //    fib.SelectEvens().PrintLines("filtered");
            //    Assert.IsTrue(true);
            //}
            $"Max Value: {maxValue}".ToConsole();
            var fib = new Problem2(maxValue).FibonacciSequence;
            fib.PrintLines("set");
            fib.SelectEvens().PrintLines("filtered");
            Assert.IsTrue(true);
        }
    }
}
