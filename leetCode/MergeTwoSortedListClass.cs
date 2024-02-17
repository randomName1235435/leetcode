namespace leetCode
{
    public class MergeTwoSortedListClass
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

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            if (list1.val > list2.val)
            {
                ListNode temp = list1;
                list1 = list2;
                list2 = temp;
            }
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
    }
}