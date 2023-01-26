public class Solution
{
    public static int MaxProfit(int[] prices)
    {
        int buy = prices[0], max_profit = 0;
        for (int i = 1; i < prices.Length; i++)
        {

            // Checking for lower buy value
            if (buy > prices[i])
                buy = prices[i];

            // Checking for higher profit
            else if (prices[i] - buy > max_profit)
                max_profit = prices[i] - buy;
        }
        return max_profit;
    }


    public static void Main()
    {
        int[] item = { 7, 1, 5, 3, 6, 4 };
        var data = MaxProfit(item);
    }
}
