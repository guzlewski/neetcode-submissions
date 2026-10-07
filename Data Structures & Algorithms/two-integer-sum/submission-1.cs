public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();

        for (int i = 0; i < nums.Length; i++) {
            dict[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++) {
            if (dict.TryGetValue(target - nums[i], out var index) && index != i) {
                return [i, index];
            }
        }

        return [0, 0];
    }
}
