using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;

namespace PE_UnitTests.One_to_10
{
    [TestClass]
    public class Problem4Tests
    {

        [TestMethod]
        public void TrimEndsTests()
        {
            
            Assert.IsTrue("aaaa".TrimEnds().Equals("aa"), "aaaa => aa");
            Assert.IsTrue("aaa".TrimEnds().Equals("a"), "aaa => a");
            Assert.IsTrue("aa".TrimEnds().Equals(""), "aa => ''");
            Assert.IsTrue("a".TrimEnds().Equals(""), "a => ''");
        }

        [TestMethod]
        public void IsPalindromeTests()
        {
            // Arrange
            Assert.IsFalse("1".IsPalindrome(), "1 is not a palindrome");
            Assert.IsTrue("11".IsPalindrome(), "11 is a palindrome");
            Assert.IsTrue("111".IsPalindrome(), "111 is a palindrome");
            Assert.IsFalse("1210".IsPalindrome(), "1210 is not a palindrome");
            Assert.IsTrue("121".IsPalindrome(), "121 is a palindrome");
            Assert.IsTrue("1221".IsPalindrome(), "1221 is a palindrome");
            Assert.IsTrue("12321".IsPalindrome(), "12321 is a palindrome");
            Assert.IsFalse("12345".IsPalindrome(), "12345 is not a palindrome");
            Assert.IsTrue("543212345".IsPalindrome(), "543212345 is a palindrome");
            
        }

    }
}
