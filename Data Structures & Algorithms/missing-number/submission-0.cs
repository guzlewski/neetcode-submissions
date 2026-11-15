public class Solution {
    public int MissingNumber(int[] nums) {
        HashSet<int> set = new(nums);

        for (int i = 0; i < nums.Length + 1; i++) {
            if (!set.Contains(i)) {
                return i;
            }
        }

        return -1;
    }
}
