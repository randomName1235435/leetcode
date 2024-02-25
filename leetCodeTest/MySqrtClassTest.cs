using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class MySqrtClassTest
    {
        [TestMethod]
        public void SimpleValidInput()
        {
            var instance = new MySqrtClass();
            var result = instance.MySqrt(4);
            Assert.IsTrue(result == 2,result.ToString());
        }
        [TestMethod]
        public void NotSoSimpleValidInput()
        {
            var instance = new MySqrtClass();
            var result = instance.MySqrt(9);
            Assert.IsTrue(result == 3,result.ToString());
        }
    }
}