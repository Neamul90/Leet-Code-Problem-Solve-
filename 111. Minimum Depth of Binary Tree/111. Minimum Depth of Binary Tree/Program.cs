
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
    public static int MinDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        //case of left and right is null then height is 1
        if (root.left == null && root.right == null)
            return root.val;
        if (root.left == null)
            return MinDepth(root.right) + 1;
        if (root.right == null)
            return MinDepth(root.left) + 1;
        
            return Math.Min(MinDepth(root.left),MinDepth(root.right))+1;
    }

    public static void Main()
    {
        TreeNode left = new TreeNode();
        left = new TreeNode(1);
        left.right = new TreeNode(3);
        left.right.right = new TreeNode(4);
        left.right.right.right = new TreeNode(4);
        var data = MinDepth(left);
    }
}
