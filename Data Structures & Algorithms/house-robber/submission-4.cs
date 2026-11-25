public class Solution {
    private int DFS(int[] nums, int index, int value, Dictionary<(int, int), int> cache) {
        if (index >= nums.Length) {
            return value;
        }

        if (cache.ContainsKey((index, value))) {
            return cache[(index, value)];
        }

        int rob = DFS(nums, index + 2, value + nums[index], cache);
        int skip = DFS(nums, index + 1, value, cache);
        int result = Math.Max(rob, skip);

        cache[(index, value)] = result;

        return result;
    }

    public int Rob(int[] nums) {
        return DFS(nums, 0, 0, []);
    }
}
