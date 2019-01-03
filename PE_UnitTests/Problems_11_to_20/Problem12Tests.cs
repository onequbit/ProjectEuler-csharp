using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeLibrary;
using ProjectEuler;
using System;

namespace PE_UnitTests.Eleven_to_20
{
    [TestClass]
    public class Problem12Tests
    {        
        [TestMethod]
        public void ShowAnswer_Test()
        {
            // Arrange
            var p12 = new Problem12();
            Assert.IsNotNull(p12, "Problem 12 Constructor is null");

            p12.ShowAnswer(10);

            // Act

            // Assert
            
        }

        [TestMethod]
        public void GetTriangleNumbers_Test()
        {
            var triangleNumbers = Problem12.GetTriangleNumbers(10);
            var expectedNumbers = new int[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 };
            "triangleNumbers:".Print(); triangleNumbers.ToConsole();
            "expectedNumbers:".Print(); expectedNumbers.ToConsole();
            Assert.IsTrue(triangleNumbers.IsEqualTo(expectedNumbers), "GetTriangleNumbers did not return expected numbers");
            
        }

        [TestMethod]
        public void ShowFactors_Test()
        {
            var triangleNumbers = Problem12.GetTriangleNumbers(10);
            Problem12.ShowFactors(triangleNumbers);
        }

        [TestMethod]
        public void GetFactorCounts_Test()
        {
            var numbers = Problem12.GetTriangleNumbers(7);
            var counts = Problem12.GetFactorCounts(numbers);
            var expected = new int[] { 1, 2, 4, 4, 4, 4, 6 };
            Assert.IsTrue(counts.IsEqualTo(expected), "counts do not match expected");
            counts.ToConsole();
            expected.ToConsole();
        }

        [TestMethod]
        public void FindNumber_Test()
        {
            int answer = Problem12.FindTriangleNumberByDivisors(5);
            int expected = 28;
            Assert.AreEqual(answer, expected, $"FindTriangleNumberByDivisors returned {answer} instead of {expected}");
            $"FindTriangleNumberByDivisors returned {answer}".ToConsole();

            var numbers = Problem12.GetTriangleNumbers(15);
            var counts = Problem12.GetFactorCounts(numbers);
            numbers.ToConsole();
            counts.ToConsole();
            $"numbers[14]:{numbers[14]}, count:{counts[14]}".ToConsole();

            answer = Problem12.FindTriangleNumberByDivisors(16);
            expected = 120;
            Assert.AreEqual(answer, expected, $"FindTriangleNumberByDivisors returned {answer} instead of {expected}");
            $"FindTriangleNumberByDivisors returned {answer}".ToConsole();

            //answer = Problem12.FindTriangleNumberByDivisors(500);            
            //$"FindTriangleNumberByDivisors returned {answer}".ToConsole();
        }

    }
}
