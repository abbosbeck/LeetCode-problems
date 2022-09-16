//121. Best Time to Buy and Sell Stock 
// Type: easy

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int max = 0;
        int min = prices[0];
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < min)
                min = prices[i];
            else if (prices[i] - min > max)
            {
                max = prices[i] - min;
            }
        }
        return max;
    }
}