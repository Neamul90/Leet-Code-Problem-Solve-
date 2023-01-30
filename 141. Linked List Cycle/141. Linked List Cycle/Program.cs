using System.Xml.Linq;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}
public class Solution
{
    public static bool HasCycle(ListNode head)
    {
        HashSet<ListNode> s = new HashSet<ListNode>();
        while (head != null)
        {
            // If we have already has this node
            // in hashmap it means their is a cycle
            // (Because you we encountering the
            // node second time).
            if (s.Contains(head))
                return true;

            // If we are seeing the node for
            // the first time, insert it in hash
            s.Add(head);

            head = head.next;
        }

        return false;
    }
    public static void Main()
    {
        ListNode item =new ListNode(3);
        item.next = new ListNode(2);
        item.next.next = new ListNode(0);
        item.next.next.next = new ListNode(-4);
        var data = HasCycle(item);
    }
}