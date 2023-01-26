
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
    public static bool HasPathSum(TreeNode root, int targetSum)
    {
       bool ans = false;
        if (root == null)
            return ans;
        int subsum = targetSum - root.val;
        if (subsum == 0 && root.left == null
            && root.right == null)
        {
            return true;
        }

        /* otherwise check both subtrees */
        if (root.left != null)
        {
            ans = ans || HasPathSum(root.left, subsum);
        }
        if (root.right != null)
        {
            ans = ans || HasPathSum(root.right, subsum);
        }
        return ans;
    }

    public static void Main()
    {
        TreeNode left = new TreeNode();
        left = new TreeNode(1);
        left.right = new TreeNode(3);
        left.right.right = new TreeNode(4);
        left.right.right.right = new TreeNode(4);
        var data = HasPathSum(left,12);
    }
}
