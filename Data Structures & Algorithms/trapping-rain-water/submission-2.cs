public class Solution {
    public int Trap(int[] height) {
        int[] left = new int[height.Length], right = new int[height.Length];

        left[0] = height[0];
        right[^1] = height[^1];

        for (int i = 1; i < left.Length; i++) {
            left[i] = Math.Max(left[i - 1], height[i]);
        }

        for (int i = right.Length - 2; i >= 0; i--) {
            right[i] = Math.Max(right[i + 1], height[i]);
        }

        int sum = 0;

        for (int i = 0; i < height.Length; i++) {
            sum += Math.Min(left[i], right[i]) - height[i];
        }

        return sum;
    }
}
