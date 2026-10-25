public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> set = [];

        foreach (var num in nums) {
            if (!set.Add(num)) {
                return num;
            }
        }

        return 0;
    }
}
