namespace leetCode
{
    public class RemoveNthFromEndClass
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

        public ListNode RemoveNthFromEnd(ListNode head, int indexFromEnd)
        {

            var lenght = GetLength(head);

            if (lenght == indexFromEnd) return head?.next;

            Remove(head, indexFromEnd, lenght);

            return head;
        }

        private void Remove(ListNode head, int indexFromEnd, int lenght)
        {
            int currentLength = 0;
            ListNode NodeBefore = null;
            ListNode NodeAfter = null;
            ListNode currentNode = head;
            while (true)
            {
                currentLength++;

                if (currentLength == lenght - indexFromEnd + 1)
                {
                    NodeAfter = NodeBefore?.next?.next;

                    NodeBefore.next = NodeAfter;
                    return;
                }
                NodeBefore = currentNode;
                currentNode = currentNode.next;
            }
        }

        private static int GetLength(ListNode head)
        {
            int lenght = 0;
            var currentNode = head;
            while (currentNode != null)
            {
                currentNode = currentNode.next;
                lenght++;
            }

            return lenght;
        }
    }
}