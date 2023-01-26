
public class Solution
{
    public static IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (numRows == 0)
        {
            return result;
        }
        List<int> row = new List<int>();
        row.Add(1);
        result.Add(row);
        if (numRows == 1)
        {
            return result;
        }
        for (int i = 1; i < numRows; i++)
        {
            var prevRow = result[i - 1];
            row = new List<int>();
            row.Add(1);
            for (int j = 0; j < prevRow.Count - 1; j++)
            {
                row.Add(prevRow[j] + prevRow[j + 1]);
            }
            row.Add(1);
            result.Add(row);
        }
        return result;
    }

    public static void Main()
    {

        var data = Generate(3);
    }
}
