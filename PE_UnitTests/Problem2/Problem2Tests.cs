using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;
using System;
using CodeLibrary;

namespace PE_UnitTests
{
    [TestClass]
    public class Problem2Tests
    {
                
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
