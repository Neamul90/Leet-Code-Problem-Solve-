using System.Xml.Linq;

namespace Solution
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
    public class Solution
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {

            if (head == null || head.next == null) return head;

            ListNode list = head;

            while (list.next != null)
            {

                if (list.val == list.next.val)
                {

                    list.next = list.next.next;
                }
                else
                {

                    list = list.next;
                }

            }
            return head;
        }
        public static void Main()
        {
            var head1 = new ListNode(2);
            head1.next = new ListNode(3);
            head1.next.next = new ListNode(4);
            head1.next.next.next = new ListNode(3);
            Console.WriteLine(DeleteDuplicates(head1));
        }
    }
}