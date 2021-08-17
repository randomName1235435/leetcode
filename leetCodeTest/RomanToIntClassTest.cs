using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class RomanToIntClassTest
    {
        [TestMethod]
        public void SimpleInput()
        {
            var instance = new RomanToIntClass();
            var result = instance.RomanToInt("LVIII");
            Assert.IsTrue(result == 58);
        }
        [TestMethod]
        public void SpecialCaseNine()
        {
            var instance = new RomanToIntClass();
            var result = instance.RomanToInt("IX");
            Assert.IsTrue(result == 9);
        }
    }
}
