using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class RemoveNthFromEndClassTest
    {
        [TestMethod]
        public void SimpleInput()
        {
            var instance = new RemoveNthFromEndClass();
            var result = instance.RemoveNthFromEnd(new RemoveNthFromEndClass.ListNode(1), 1);
            Assert.IsTrue(result == null);
        }
        [TestMethod]
        public void FiveLengthInput()
        {
            var param = new RemoveNthFromEndClass.ListNode(1,
                new RemoveNthFromEndClass.ListNode(2,
                    new RemoveNthFromEndClass.ListNode(3,
                        new RemoveNthFromEndClass.ListNode(4, new
                            RemoveNthFromEndClass.ListNode(5)))));
            var instance = new RemoveNthFromEndClass();
            var result = instance.RemoveNthFromEnd(param, 2);
            Assert.IsTrue(result.val == 1 &&
                          result.next.val == 2 &&
                          result.next.next.val == 3 &&
                          result.next.next.next.val == 5);
        }
        [TestMethod]
        public void TwoLengthInput()
        {
            var param = new RemoveNthFromEndClass.ListNode(1,
                new RemoveNthFromEndClass.ListNode(2));
            var instance = new RemoveNthFromEndClass();
            var result = instance.RemoveNthFromEnd(param, 2);
            Assert.IsTrue(result.val == 2);
        }
    }
}