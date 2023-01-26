
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

    public static TreeNode SortedArrayToBST(int[] nums)
    {
        return helper(nums, 0, nums.Length - 1);
    }
    static TreeNode helper(int[] nums, int low, int high)
    {
        if (low > high)
        {
            return null;
        }

        int mid = low + (high - low) / 2;
        //center val of sorted array as the root of the bst
        TreeNode head = new TreeNode(nums[mid]);

        //left of the mid value should go to the left of this root node to satisfy bst
        head.left = helper(nums, low, mid - 1);
        //right of the mid value should go to the right of this root node to satisfy bst
        head.right = helper(nums, mid + 1, high);
        return head;

    }
    public static void Main()
    {
        int[] left = { -10, -3, 0, 5, 9 };
        var data = SortedArrayToBST(left);
    }
}
