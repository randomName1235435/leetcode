using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class GenerateParenthesesClassTest
    {
        [TestMethod]
        public void SimpleValidInput()
        {
            var instance = new GenerateParenthesesClass();
            var result = instance.GenerateParenthesis(1);
            Assert.IsTrue(result[0] == "()");
        }
    }
}