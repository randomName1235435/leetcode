using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetCode;

namespace leetCodeTest
{
    [TestClass]
    public class IsMatchClassTest
    {
        [TestMethod]
        public void SimpleInput()
        {
            var instance = new IsMatchClass();
            var result = instance.IsMatch("aa", "a");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AsterixInput()
        {
            var instance = new IsMatchClass();
            var result = instance.IsMatch("aa", "a*");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Any()
        {
            var instance = new IsMatchClass();
            var result = instance.IsMatch("aa", ".*");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MultipleAsterix()
        {
            var instance = new IsMatchClass();
            var result = instance.IsMatch("aab", "c*a*b");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MultipleAsterixLonginputFalse()
        {
            var instance = new IsMatchClass();
            var result = instance.IsMatch("mississippi", "mis*is*p*.");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void MultipleAsterixLonginputTrue()
        {
            var instance = new IsMatchClass();
            var result = instance.IsMatch("mississippi", "mis*is*ip*.");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AnyWithMore()
        {
            var instance = new IsMatchClass();
            var result = instance.IsMatch("ab", ".*c");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void AnyWithMoreSameLiteral()
        {
            var instance = new IsMatchClass();
            var result = instance.IsMatch("aaa", "a*a");
            Assert.IsTrue(result);
        }
    }
}
