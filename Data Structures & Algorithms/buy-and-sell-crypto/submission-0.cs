public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 0, profit = 0;

        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < prices[buy]) {
                buy = i;
            } else {
                profit = Math.Max(profit, prices[i] - prices[buy]);
            }
        }

        return profit;
    }
}
