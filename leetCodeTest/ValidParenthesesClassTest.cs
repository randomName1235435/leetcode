using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class ValidParenthesesClassTest
    {
        [TestMethod]
        public void SimpleValidInput()
        {
            var instance = new ValidParenthesesClass();
            var result = instance.IsValid("()");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void SimpleThoValidInput()
        {
            var instance = new ValidParenthesesClass();
            var result = instance.IsValid("()[]{}");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void SimpleInValidInput()
        {
            var instance = new ValidParenthesesClass();
            var result = instance.IsValid("(]");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void NotSoSimpleInValidInput()
        {
            var instance = new ValidParenthesesClass();
            var result = instance.IsValid("([)]");
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void SimpleSimpleInValidInput()
        {
            var instance = new ValidParenthesesClass();
            var result = instance.IsValid("]");
            Assert.IsFalse(result);
        }
    }
}