using System;
using leetCode;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class AddTwoNumbersClassTest
    {

        [TestMethod]
        public void AddTwoNumbersZeroTest()
        {
            AddTwoNumbersClass instance = new AddTwoNumbersClass();
            var firstParam = new ListNode (0);
            var secondParam = new ListNode(0);
            var result = instance.AddTwoNumbers (firstParam, secondParam);
            Assert.IsTrue(result.val == 0) ;
        }
        [TestMethod]
        public void AddTwoNumbersZeroTestExample()
        {
            AddTwoNumbersClass instance = new AddTwoNumbersClass();
            var firstParam = new ListNode(2,new ListNode( 4, new ListNode( 3)));
            var secondParam = new ListNode(5, new ListNode(6, new ListNode(4)));
            var result = instance.AddTwoNumbers(firstParam, secondParam);
            Assert.IsTrue(result.val == 7 && result.next.val == 0 && result.next.next.val == 8);
        }
    }
}
