public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int[] mins = new int[cost.Length + 1];

        for (int i = 2; i < mins.Length; i++) {
            mins[i] = Math.Min(mins[i - 2] + cost[i - 2], mins[i - 1] + cost[i - 1]);
        }

        return mins[^1];
    }
}
