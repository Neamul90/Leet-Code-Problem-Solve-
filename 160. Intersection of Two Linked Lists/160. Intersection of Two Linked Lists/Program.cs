
using System.Collections.Generic;
using System.Xml.Linq;


//Definition for singly - linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}


public class Solution
{
    public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        while (headB != null)
        {
            ListNode temp = headA;
            while (temp != null)
            {

                // if both Nodes are same
                if (temp == headB)
                {
                    return headB;
                }
                temp = temp.next;
            }
            headB = headB.next;
        }

        // If intersection is not present between the lists,
        // return NULL.
        return null;
    }
    public static void Main()
    {
        ListNode head1 = new ListNode(10);
        ListNode head2 = new ListNode(3);

        ListNode newNode = new ListNode(6);
        head2.next = newNode;

        newNode = new ListNode(9);
        head2.next.next = newNode;

        newNode = new ListNode(15);
        head1.next = newNode;
        head2.next.next.next = newNode;

        newNode = new ListNode(30);
        head1.next.next = newNode;

        head1.next.next.next = null;
        var data= GetIntersectionNode(head1, head2);
    }
}