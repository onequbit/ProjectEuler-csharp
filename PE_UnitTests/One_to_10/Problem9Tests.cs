using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;
using CodeLibrary;

namespace PE_UnitTests.One_to_10
{
    [TestClass]
    public class Problem9Tests
    {        
        
        [TestMethod]
        public void Test_findTriplets()
        {
            // Arrange
            var triplets = new Problem9(1000);

            // Act

            // Assert
            triplets.Answer.ToConsole();
            //Assert.Fail();
        }
    }
}
