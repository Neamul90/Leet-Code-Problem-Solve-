
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

    public static int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        int leftMax = MaxDepth(root.left);
        int rightMax = MaxDepth(root.right);
        if(leftMax > rightMax)
            return leftMax+1;
        else
            return rightMax+1;
    }
    public static void Main()
    {
        TreeNode left = new TreeNode();
        TreeNode right = new TreeNode();
        left = new TreeNode(1);
        left.left = new TreeNode(2);
        left.right = new TreeNode(2);
        left.left.left = new TreeNode(3);
        left.left.right = new TreeNode(4);
        left.right.left = new TreeNode(4);
        left.right.right = new TreeNode(3);
        var data = MaxDepth(left);
    }
}
