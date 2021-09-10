using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetCode;

namespace leetCodeTest
{
    [TestClass]
    public class LongestCommonPrefixClassTest
    {
        [TestMethod]
        public void SimpleInput()
        {
            var instance = new LongestCommonPrefixClass();
            var result = instance.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            Assert.IsTrue(result == "fl");
        }
        [TestMethod]
        public void NoPrefix()
        {
            var instance = new LongestCommonPrefixClass();
            var result = instance.LongestCommonPrefix(new string[] { "dog","racecar","car"});
            Assert.IsTrue(result == "");
        }
        [TestMethod]
        public void FirstEmptyValue()
        {
            var instance = new LongestCommonPrefixClass();
            var result = instance.LongestCommonPrefix(new string[] { "", "b" });
            Assert.IsTrue(result == "");
        }
        [TestMethod]
        public void OnlyEmptyValues()
        {
            var instance = new LongestCommonPrefixClass();
            var result = instance.LongestCommonPrefix(new string[] { "" });
            Assert.IsTrue(result == "");
        }
        [TestMethod]
        public void ShortPrefix()
        {
            var instance = new LongestCommonPrefixClass();
            var result = instance.LongestCommonPrefix(new string[] { "ab","a" });
            Assert.IsTrue(result == "a");
        }
        [TestMethod]
        public void SecondShortPrefix()
        {
            var instance = new LongestCommonPrefixClass();
            var result = instance.LongestCommonPrefix(new string[] { "aa", "ab" });
            Assert.IsTrue(result == "a");
        }
    }
}
