using System.Collections.Generic;

namespace leetCode
{

    public class DeleteDuplicatesClass
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode DeleteDuplicates(ListNode head)
        {
            var hashset = new List<int>();

            ListNode currentNode = head;
            ListNode before = head;
            while (currentNode != null)
            {
                if (hashset.Contains(currentNode.val))
                {
                    before.next = currentNode.next;
                }
                else
                {
                    hashset.Add(currentNode.val);
                    before = currentNode;
                }
                currentNode = currentNode.next;
            }

            return head;
        }
    }
}
