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
    public static IList<int> list = new List<int>();

    public static IList<int> InorderTraversal(TreeNode root)
    {
        printInorder(root);
        return list;
    }
    static void printInorder(TreeNode node)
    {
        if (node == null)
            return;
        /* then recur on left subtree */
        printInorder(node.left);

        /* first print data of node */
        list.Add(node.val);

        /* now recur on right subtree */
        printInorder(node.right);
    }
    public static void Main()
    {
        TreeNode root = new TreeNode();
        root = new TreeNode(1);
        root.left = new TreeNode(12);
        root.right = new TreeNode(9);
        root.left.left = new TreeNode(5);
        root.left.right = new TreeNode(6);
        var data = InorderTraversal(root);
    }
}