using System;
using leetCode;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void TwoSummTest()
        {
            TwoSum instance = new TwoSum();
            var firstParam = new int[] { 1,2,3,4};
            var secondParam = 6;
            var result = instance.TwoSumm(firstParam,secondParam);
            Assert.IsTrue(firstParam[result[0]] + firstParam[result[1]] == secondParam);
        }
        [TestMethod]
        public void TwoSumTargetAndZeroInParameterTest()
        {
            TwoSum instance = new TwoSum();
            var firstParam = new int[] { 0,1, 2, 3, 6 };
            var secondParam = 6;
            var result = instance.TwoSumm(firstParam, secondParam);
            Assert.IsTrue(result.Contains(0) && result.Contains(4));
        }
        [TestMethod]
        public void TwoSumNoPossibleSolution()
        {
            TwoSum instance = new TwoSum();
            var firstParam = new int[] { 0, 0,0,0, };
            var secondParam = 6;
            var result = instance.TwoSumm(firstParam, secondParam);
            Assert.IsNull(result);
        }
        [TestMethod]
        public void TwoSumDontGetTwoTimesSame()
        {
            TwoSum instance = new TwoSum();
            var firstParam = new int[] { 2,6, 7, 4, 3, };
            var secondParam = 12;
            var result = instance.TwoSumm(firstParam, secondParam);
            Assert.IsTrue(result == null || result[0] != 2 && result[1] != 2);
        }
        [TestMethod]
        public void TwoSumZeroTargetZeroNumsTest()
        {
            TwoSum instance = new TwoSum();
            var firstParam = new int[] { 0,4,3,0 };
            var secondParam = 0;
            var result = instance.TwoSumm(firstParam, secondParam);
            Assert.IsTrue( result[0] == 0 && result[1] == 3);
        }
    }
}
