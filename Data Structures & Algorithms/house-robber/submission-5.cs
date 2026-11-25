public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) {
            return nums[0];
        }

        int[] loot = new int[nums.Length];

        loot[0] = nums[0];
        loot[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < loot.Length; i++) {
            loot[i] = Math.Max(nums[i] + loot[i - 2], loot[i - 1]);
        }

        return Math.Max(loot[^1], loot[^2]);
    }
}
