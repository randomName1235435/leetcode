using System;
using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class FindMedianSortedArraysClassTest
    {
        [TestMethod]
        public void FindMedianSortedArraysThreeTotalNumbsSimple()
        {
            FindMedianSortedArraysClass instance = new FindMedianSortedArraysClass();
            var result = instance.FindMedianSortedArrays(new int[] { 1,3}, new int[] { 2});
            Assert.IsTrue(result == 2);
        }
        [TestMethod]
        public void FindMedianSortedArraysFourTotalNumbsSimple()
        {
            FindMedianSortedArraysClass instance = new FindMedianSortedArraysClass();
            var result = instance.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3,4 });
            Assert.IsTrue(result == 2.5f);
        }
    }
}
