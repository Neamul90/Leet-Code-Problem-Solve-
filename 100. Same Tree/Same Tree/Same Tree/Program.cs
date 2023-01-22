using System;
using System.Xml.Linq;

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

    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;
        if (p.val != q.val) return false;
        return IsSameTree(p.left, q.left)
                && IsSameTree(p.right, q.right);
    }
    public static void Main()
    {
        TreeNode left = new TreeNode();
        TreeNode right = new TreeNode();
        left = new TreeNode(1);
        left.left = new TreeNode(12);
        left.right = new TreeNode(9);
        left.left.left = new TreeNode(9);
        left.left.right = new TreeNode(6);
        right = new TreeNode(1);
        right.left = new TreeNode(12);
        right.right = new TreeNode(9);
        right.left.left = new TreeNode(5);
        right.left.right = new TreeNode(6);
        var data = IsSameTree(left,right);
    }
}