
public class Solution
{
    public static IList<int> GetRow(int rowIndex)
    {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> row = new List<int>();
        row.Add(1);
        result.Add(row);
        if (rowIndex == 0)
        {
            return result[rowIndex];
        }
        if (rowIndex == 1)
        {
            row.Add(1);
            return result[rowIndex-1];
        }
        for (int i = 1; i < rowIndex+1; i++)
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
        return result[rowIndex];
    }


    public static void Main()
    {

        var data = GetRow(3);
    }
}
