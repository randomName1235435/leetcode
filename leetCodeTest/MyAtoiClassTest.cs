using System;
using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class MyAtoiClassTest
    {
        [TestMethod]
        public void SimpleInput()
        {
            var instance = new MyAtoiClass();
            var result = instance.MyAtoi("123");
            Assert.IsTrue(result == 123);
        }
        [TestMethod]
        public void MaxInt()
        {
            var instance = new MyAtoiClass();
            var result = instance.MyAtoi("91283472332");
            Assert.IsTrue(result == int.MaxValue);
        }
        [TestMethod]
        public void MinInt()
        {
            var instance = new MyAtoiClass();
            var result = instance.MyAtoi("-91283472332");
            Assert.IsTrue(result == int.MinValue);
        }
        [TestMethod]
        public void WordsFirst()
        {
            var instance = new MyAtoiClass();
            var result = instance.MyAtoi("987 words and");
            Assert.IsTrue(result == 987);
        }
        [TestMethod]
        public void WordsLast()
        {
            var instance = new MyAtoiClass();
            var result = instance.MyAtoi("words and 987");
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void NegativInputAndWhitespace()
        {
            var instance = new MyAtoiClass();
            var result = instance.MyAtoi("    -42");
            Assert.IsTrue(result == -42);
        }
        [TestMethod]
        public void WhitespaceNegativAndWords()
        {
            var instance = new MyAtoiClass();
            var result = instance.MyAtoi("  -0012a42");
            Assert.IsTrue(result == -12);
        }
        
    }
}
