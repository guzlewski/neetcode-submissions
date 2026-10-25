public class Solution {
    public int FindDuplicate(int[] nums) {
        int slow = nums[0], fast = nums[nums[0]];

        while (nums[slow] != nums[fast]) {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }

        int cycle = 0;

        while (nums[slow] != nums[cycle]) {
            slow = nums[slow];
            cycle = nums[cycle];
        }

        return nums[slow];
    }
}
