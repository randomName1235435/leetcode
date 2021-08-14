using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetCode;
namespace leetCodeTest
{
    [TestClass]
    public class IsPalindromeClassTest
    {
        [TestMethod]
        public void SimpleInput()
        {
            var instance = new IsPalindromeClass();
            var result = instance.IsPalindrome(121);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void NegativInteger()
        {
            var instance = new IsPalindromeClass();
            var result = instance.IsPalindrome(-121);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void MaxInteger()
        {
            var instance = new IsPalindromeClass();
            var result = instance.IsPalindrome(int.MaxValue);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void ShortInteger()
        {
            var instance = new IsPalindromeClass();
            var result = instance.IsPalindrome(10);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void HighInteger()
        {
            var instance = new IsPalindromeClass();
            var result = instance.IsPalindrome(1223221);
            Assert.IsTrue(result);
        }
    }
}
