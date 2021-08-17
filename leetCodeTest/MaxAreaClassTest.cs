using System;
using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class MaxAreaClassTest
    {
        [TestMethod]
        public void SimpleInput()
        {
            var instance = new MaxAreaClass();
            var result = instance.MaxArea(new int[] { 4, 3, 2, 1, 4 });
            Assert.IsTrue(result == 16);

        }
    }
}
