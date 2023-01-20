// See https://aka.ms/new-console-template for more information
using System;

namespace Program
{
    public class Program
    {
        public static string AddBinary(string a, string b)
        {
            //    **Rememeber,
            //1 + 1 = 0 with carry 1
            //1 + 0 = 1 with carry 0
            //0 + 1 = 1 with carry 0
            //0 + 0 = 0 with carry 0

            // Initialize result
            string result = "";

            // Initialize digit sum
            int s = 0;

            // Traverse both strings starting
            // from last characters
            int i = a.Length - 1, j = b.Length - 1;
            while (i >= 0 || j >= 0 || s == 1)
            {

                // Comput sum of last
                // digits and carry
                s += ((i >= 0) ? a[i] - '0' : 0);
                s += ((j >= 0) ? b[j] - '0' : 0);

                // If current digit sum is
                // 1 or 3, add 1 to result
                result = (char)(s % 2 + '0') + result;

                // Compute carry
                s /= 2;

                // Move to next digits
                i--; j--;
            }
            return result;
        }
        public static void Main()
        {
            string a = "1010", b = "1011";
            var result = AddBinary(a, b);
            Console.WriteLine(result);
        }
    }
}