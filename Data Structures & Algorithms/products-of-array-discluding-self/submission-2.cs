public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length], suffix = new int[nums.Length],
              result = new int[nums.Length];

        prefix[0] = 1;
        suffix[^1] = 1;

        for (int i = 1; i < nums.Length; i++) {
            prefix[i] = nums[i - 1] * prefix[i - 1];
        }

        for (int j = nums.Length - 2; j >= 0; j--) {
            suffix[j] = nums[j + 1] * suffix[j + 1];
        }

        for (int i = 0; i < result.Length; i++) {
            result[i] = prefix[i] * suffix[i];
        }

        return result;
    }
}
