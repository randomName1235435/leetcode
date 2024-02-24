using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class DeleteDuplicatesClassTest
    {
        [TestMethod]
        public void SimpleValidInput()
        {
            var instance = new DeleteDuplicatesClass();
            var result = instance.DeleteDuplicates(new DeleteDuplicatesClass.ListNode(1,new DeleteDuplicatesClass.ListNode(1)));
            Assert.IsTrue(result.val == 1 && result.next == null);
        }
        [TestMethod]
        public void TrickyValidInput()
        {
            var instance = new DeleteDuplicatesClass();
            var result = instance.DeleteDuplicates(new DeleteDuplicatesClass.ListNode(1, new DeleteDuplicatesClass.ListNode(1,new DeleteDuplicatesClass.ListNode(1))));
            Assert.IsTrue(result.val == 1 && result.next == null);
        }
    }
}