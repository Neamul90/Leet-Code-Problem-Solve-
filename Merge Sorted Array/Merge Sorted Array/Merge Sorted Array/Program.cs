namespace Solution
{
    public class Solution
    {
        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] nums3 = new int[n+m];
            int i = 0, j = 0, k = 0;
            while (i < n && j < m)
            {
                if (nums1[i] < nums2[j])
                    nums3[k++] = nums1[i++];
                else
                    nums3[k++] = nums2[j++];
            }
            while (i < m)
                nums3[k++] = nums1[i++];

            while (j < n)
                nums3[k++] = nums2[j++];
            return nums3;
        }
        public static void Main()
        {
            int[] nums1 = { 1}, nums2 = { };
            int m = 1, n = 0;
            Merge(nums1, m, nums2, n);
            Console.WriteLine();
        }
    }
}
