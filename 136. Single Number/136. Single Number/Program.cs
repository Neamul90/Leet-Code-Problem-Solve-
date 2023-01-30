using System;
using System.Text;
using System.Text.RegularExpressions;

public class Solution
{
    public static int SingleNumber(int[] nums)
    {
        foreach(var item in nums.Distinct())
        {
            var items = nums.Where(a => a.Equals(item));
            if(items.Count()<=1)
                return item;
               
        }
        return 0;
    }


    public static void Main()
    {
        int[] ints = { 4, 1, 2, 1, 2 };
        var data = SingleNumber(ints);
    }
}