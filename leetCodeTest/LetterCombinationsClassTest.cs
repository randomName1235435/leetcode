using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class LetterCombinationsClassTest
    {
        [TestMethod]
        public void EmptyInput()
        {
            var instance = new LetterCombinationsClass();
            var result = instance.LetterCombinations("");
            Assert.IsTrue(result.Count == 0);
        }
        [TestMethod]
        public void OneNumberInput()
        {
            var instance = new LetterCombinationsClass();
            var result = instance.LetterCombinations("2");
            Assert.IsTrue(result[0] == "a" && result[1] == "b" && result[2] == "c");
        }
        [TestMethod]
        public void TwoNumberInput()
        {
            var instance = new LetterCombinationsClass();
            var result = instance.LetterCombinations("23");
            Assert.IsTrue(result[0] == "ad" && 
                          result[1] == "ae" && 
                          result[2] == "af" && 
                          result[3] == "bd" && 
                          result[4] == "be" && 
                          result[5] == "bf" && 
                          result[6] == "cd" && 
                          result[7] == "ce" && 
                          result[8] == "cf");
        }
    }
}
