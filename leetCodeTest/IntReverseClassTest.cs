using System;
using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class IntReverseClassTest
    {
        [TestMethod]
        public void SimpleInput()
        {
            var instance = new IntReverseClass();
            var result = instance.Reverse(123);
            Assert.IsTrue(result == 321);
        }
        [TestMethod]
        public void MaxValue()
        {
            var instance = new IntReverseClass();
            var result = instance.Reverse(int.MaxValue);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void MinValue()
        {
            var instance = new IntReverseClass();
            var result = instance.Reverse(int.MinValue);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void ZeroFirst()
        {
            var instance = new IntReverseClass();
            var result = instance.Reverse(120);
            Assert.IsTrue(result == 21);
        }
    }
}
