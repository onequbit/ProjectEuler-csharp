using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeLibrary;
using ProjectEuler;
using System;
using System.Collections.Generic;

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

            p12.ShowAnswer(4);
            p12.ShowAnswer(6);
            p12.ShowAnswer(16);
            p12.ShowAnswer(100);
            p12.ShowAnswer(500);

            // Act

            // Assert

        }

        
        [TestMethod]
        public void ShowTriangles_Test()
        {
            int limit = 10;            
            List<int> numbers = new List<int> { };
            var p = new Problem12();
            foreach (int number in p.TriangleNumbers(limit))
            {
                numbers.Add(number);
                if (numbers.Count == limit) break;
            }
            numbers.ToArray().ToConsole();
        }
    }
}
