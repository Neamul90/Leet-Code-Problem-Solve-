
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

    public static IList<int> PostorderTraversal(TreeNode root)
    {
        printPostorder(root);
        return list;
    }
    static void printPostorder(TreeNode node)
    {
        if (node == null)
            return;
        
        /* then recur on left subtree */
        printPostorder(node.left);
        /* now recur on right subtree */
        printPostorder(node.right);
        /* first print data of node */
        list.Add(node.val);
    }
    public static void Main()
    {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(5);
        PostorderTraversal(root);
    }
}