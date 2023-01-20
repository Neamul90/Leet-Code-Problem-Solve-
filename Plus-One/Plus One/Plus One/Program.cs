// See https://aka.ms/new-console-template for more information
using System;

namespace Solution
{
    public class Solution
    {
        public static int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;
            return newNumber;
            
        }
        public static void Main()
        {
            int[] digits = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            var result = PlusOne(digits);
            Console.WriteLine(result);
        }
    }
}