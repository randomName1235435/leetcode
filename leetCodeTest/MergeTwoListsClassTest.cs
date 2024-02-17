using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class MergeTwoListsClassTest
    {
        [TestMethod]
        public void SimpleValidInput()
        {
            var instance = new MergeTwoSortedListClass();
            var result = instance.MergeTwoLists(
                new MergeTwoSortedListClass.ListNode(1, new MergeTwoSortedListClass.ListNode(2)),
                new MergeTwoSortedListClass.ListNode(1, new MergeTwoSortedListClass.ListNode(2))
            );
            Assert.IsTrue(result.val == 1 &&
                          result.next.val == 1 &&
                          result.next.next.val == 2 &&
                          result.next.next.next.val == 2);
        }
        [TestMethod]
        public void AlsoSimpleValidInput()
        {
            var instance = new MergeTwoSortedListClass();
            var result = instance.MergeTwoLists(
                new MergeTwoSortedListClass.ListNode(1, new MergeTwoSortedListClass.ListNode(2, new MergeTwoSortedListClass.ListNode(4))),
                new MergeTwoSortedListClass.ListNode(1, new MergeTwoSortedListClass.ListNode(3, new MergeTwoSortedListClass.ListNode(4)))
            );
            Assert.IsTrue(result.val == 1 &&
                          result.next.val == 1 &&
                          result.next.next.val == 2 &&
                          result.next.next.next.val == 3 &&
                          result.next.next.next.next.val == 4 &&
                          result.next.next.next.next.next.val == 4);
        }
        [TestMethod]
        public void TrapInValidInput()
        {
            var instance = new MergeTwoSortedListClass();
            var result = instance.MergeTwoLists(null,
                new MergeTwoSortedListClass.ListNode(0));
            Assert.IsTrue(result.val == 0);
        }
        [TestMethod]
        public void FirstListStartsBiggerValidInput()
        {
            var instance = new MergeTwoSortedListClass();
            var result = instance.MergeTwoLists(
                new MergeTwoSortedListClass.ListNode(2),
                new MergeTwoSortedListClass.ListNode(1));
            Assert.IsTrue(result.val == 1 && result.next.val == 2);
        }
    }
}