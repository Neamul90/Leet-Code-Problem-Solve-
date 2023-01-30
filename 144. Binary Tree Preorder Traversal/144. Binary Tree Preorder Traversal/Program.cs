
using System.Collections.Generic;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public static IList<int> list = new List<int>();

    public static IList<int> PreorderTraversal(TreeNode root)
    {
        printPreorder(root);
        return list;
    }
    static void printPreorder(TreeNode node)
    {
        if (node == null)
            return;
        /* first print data of node */
        list.Add(node.val);
        /* then recur on left subtree */
        printPreorder(node.left);
        /* now recur on right subtree */
        printPreorder(node.right);
    }
    public static void Main()
    {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left =new TreeNode(5);
        PreorderTraversal(root);
    }
}