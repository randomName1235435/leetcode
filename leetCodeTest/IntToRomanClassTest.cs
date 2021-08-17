using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class IntToRomanClassTest
    {
        [TestMethod]
        public void SimpleInput()
        {
            var instance = new IntToRomanClass();
            var result = instance.IntToRoman(58);
            Assert.IsTrue(result == "LVIII");
        }
        [TestMethod]
        public void SpecialCaseNine()
        {
            var instance = new IntToRomanClass();
            var result = instance.IntToRoman(9);
            Assert.IsTrue(result == "IX");
        }
    }
}
