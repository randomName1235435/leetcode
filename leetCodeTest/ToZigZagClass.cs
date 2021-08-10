using System;
using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class ToZigZagClassTest
    {
        [TestMethod]
        public void SimpleInput()
        {
            var instance = new ToZigZagClass();
                var result =instance.ToZigZag("PAYPALISHIRING",3);
            Assert.IsTrue(result == "PAHNAPLSIIGYIR");
        }
    }
}
