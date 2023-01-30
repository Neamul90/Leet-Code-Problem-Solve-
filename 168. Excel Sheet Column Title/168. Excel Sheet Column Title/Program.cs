
public class Solution
{
    static String reverse(String input)
    {
        char[] reversedString = input.ToCharArray();
        Array.Reverse(reversedString);
        return new String(reversedString);
    }
    public static string ConvertToTitle(int columnNumber)
    {
        String columnName = "";

        while (columnNumber > 0)
        {

            // Find remainder
            int rem = columnNumber % 26;

            // If remainder is 0, then a
            // 'Z' must be there in output
            if (rem == 0)
            {
                columnName += "Z";
                columnNumber = (columnNumber / 26) - 1;
            }

            // If remainder is non-zero
            else
            {
                columnName += (char)((rem - 1) + 'A');
                columnNumber = columnNumber / 26;
            }
        }

        // Reverse the string
        columnName = reverse(columnName);
        return columnName;
    }
    public static void Main()
    {
        ConvertToTitle(80);
        ConvertToTitle(676);
        ConvertToTitle(702);
        ConvertToTitle(705);
    }
}