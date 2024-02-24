using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class ClimbingStairsClassTest
    {
        [TestMethod]
        public void SimpleValidInput()
        {
            var instance = new ClimbingStairsClass();
            var result = instance.ClimbStairs(4);
            Assert.IsTrue(result ==5);
        }
    }
}