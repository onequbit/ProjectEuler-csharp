using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeLibrary;
using ProjectEuler;
using System;
using System.Linq;


namespace PE_UnitTests.One_to_10
{
    [TestClass]
    public class Problem10Tests
    {
                
        [TestMethod]
        public void GetPrimesUpTo_StateUnderTest_ExpectedBehavior()
        {
            // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

            // Arrange
            var p10 = new Problem10(10);
            
            string answer = p10.Answer; // "2,3,5,7,sum of primes under 10: 17"
            int numberAnswer = 0;
            bool parsed = int.TryParse(p10.Answer.Split(" ").Last(), out numberAnswer);

            Assert.IsTrue(parsed, "number parse failed");
            Assert.IsTrue(numberAnswer == 17, $"{numberAnswer} != 17");

            answer.ToConsole();
        }
    }
}
