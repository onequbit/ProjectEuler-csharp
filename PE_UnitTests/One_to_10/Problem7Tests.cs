using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeLibrary;
using ProjectEuler;
using System;

namespace PE_UnitTests.One_to_10
{
    [TestClass]
    public class Problem7Tests
    {
        
        [TestMethod]
        public void FindPrimes_Test()
        {
            // Arrange            
            // Act
            // Assert            
            for (int i = 4; i<15; i++)
                Assert.IsTrue(new Problem7().FindPrimes(i).Count == i);
        }

        [TestMethod]
        public void Problem7_Test()
        {
            // Arrange              
            // Act
            // Assert   
            Assert.IsTrue(new Problem7().FindPrimes(3).Last() == 5);
            Assert.IsTrue(new Problem7().FindPrimes(4).Last() == 7);
            Assert.IsTrue(new Problem7().FindPrimes(5).Last() == 11);
            Assert.IsTrue(new Problem7().FindPrimes(6).Last() == 13);
            Assert.IsTrue(new Problem7().FindPrimes(7).Last() == 17);

        }
    }
}
