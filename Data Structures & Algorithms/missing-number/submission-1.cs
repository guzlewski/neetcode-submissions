public class Solution {
    public int MissingNumber(int[] nums) {
        int xor = 0;
        for (int i = 0; i <= nums.Length; i++) {
            xor ^= i;
        }

        int sum = 0;
        for (int i = 0; i < nums.Length; i++) {
            sum ^= nums[i];
        }

        return sum ^ xor;
    }
}
