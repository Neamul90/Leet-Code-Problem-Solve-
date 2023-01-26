using System;
using System.Text;
using System.Text.RegularExpressions;

public class Solution
{
    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))         // if String s is empty return true
            return true;
        string str = Regex.Replace(s, @"[^0-9a-zA-Z]", string.Empty).ToLower();
        if (str.Length <= 1)
            return true;
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        String rstr = new String(chars);
        if (str.Equals(rstr))//if string and reversed string both are equal return true
            return true;
        return false;


    }
 

    public static void Main()
    {
        var data = IsPalindrome("a.");
    }
}