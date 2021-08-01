using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class AddTwoNumbersClass
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode first = result;
            int overflow = 0;

            while (l1 != null || l2 != null)
            {
                int sum = overflow;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                if (sum >= 10)
                {
                    overflow = sum / 10;
                    sum = sum % 10;
                }
                else
                    overflow = 0;

                result.next = new ListNode(sum);
                result = result.next;
            }

            if (overflow > 0)
                result.next = new ListNode(overflow);
            return first = first.next;
        }
    }
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
}
