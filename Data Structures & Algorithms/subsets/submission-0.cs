public class Solution {
    List<List<int>> result = [];

    private void Generate(int[] nums, int index, List<int> current) {
        if (index == nums.Length) {
            result.Add(current);
            return;
        }

        Generate(nums, index + 1, current);

        current = new(current);
        current.Add(nums[index]);
        Generate(nums, index + 1, current);
    }

    public List<List<int>> Subsets(int[] nums) {
        Generate(new HashSet<int>(nums).ToArray(), 0, []);

        return result;
    }
}
