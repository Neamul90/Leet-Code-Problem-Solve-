namespace Solution
{
    public class Solution
    {

        public static void merge(int[] nums1, int m, int[] nums2, int n)
        {
            int index = m + n - 1;  //last index
            while (n > 0)
            {
                if (m > 0 && nums1[m - 1] > nums2[n - 1])
                {
                    nums1[index] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[index] = nums2[n - 1];
                    n--;
                }
                index--;
            }
        }
        public static void Main()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 }, nums2 = { 2, 5, 6 };
            int m = 3, n = 3;
            merge(nums1, m, nums2, n);
            Console.WriteLine();
        }
    }
}
