using System;
using System.Diagnostics;
using leetCode;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class ThreeSumClosestClassTest
    {
        [TestMethod]
        public void ThreeSumTest()
        {
            ThreeSumClosestClass instance = new ThreeSumClosestClass();
            var firstParam = new int[] { -1, 2, 1, -4 };
            var result = instance.ThreeSumClosest(firstParam,1);
            Assert.IsTrue(result == 2);
        }
    }
}
