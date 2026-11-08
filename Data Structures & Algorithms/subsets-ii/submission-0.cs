public class Solution {
    private void Backtrack(int[] nums, int index, List<int> current, List<List<int>> result) {
        if (index == nums.Length) {
            result.Add(new(current));
            return;
        }

        current.Add(nums[index]);
        Backtrack(nums, index + 1, current, result);
        current.RemoveAt(current.Count - 1);

        while (index < nums.Length - 1 && nums[index] == nums[index + 1]) {
            index++;
        }

        Backtrack(nums, index + 1, current, result);
    }

    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = [];
        Backtrack(nums, 0, [], result);

        return result;
    }
}
