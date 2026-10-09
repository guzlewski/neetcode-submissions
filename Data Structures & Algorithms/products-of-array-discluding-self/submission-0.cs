public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] left = new int[nums.Length], right = new int[nums.Length];

        Array.Fill(left, 1);
        Array.Fill(right, 1);

        for (int i = 0; i < nums.Length; i++) {
            left[i] = nums[i] * (i - 1 >= 0 ? left[i - 1] : 1);
        }

        for (int j = nums.Length - 1; j >= 0; j--) {
            right[j] = nums[j] * (j + 1 < nums.Length ? right[j + 1] : 1);
        }

        int[] result = new int[nums.Length];

        for (int i = 0; i < result.Length; i++) {
            int leftVal = 1, rightVal = 1;

            if (i - 1 >= 0) {
                leftVal = left[i - 1];
            }

            if (i + 1 < result.Length) {
                rightVal = right[i + 1];
            }

            result[i] = leftVal * rightVal;
        }

        return result;
    }
}
