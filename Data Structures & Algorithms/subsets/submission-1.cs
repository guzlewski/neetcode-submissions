public class Solution {
    List<List<int>> result = [];

    private void Generate(int[] nums, int index, List<int> current) {
        if (index == nums.Length) {
            result.Add(new(current));
            return;
        }

        current.Add(nums[index]);
        Generate(nums, index + 1, current);
        current.Remove(nums[index]);

        Generate(nums, index + 1, current);
    }

    public List<List<int>> Subsets(int[] nums) {
        Generate(new HashSet<int>(nums).ToArray(), 0, []);

        return result;
    }
}
