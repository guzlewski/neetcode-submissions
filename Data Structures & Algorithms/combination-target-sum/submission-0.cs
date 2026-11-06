public class Solution {
    private void DFS(int[] nums, int index, int target, List<int> current, List<List<int>> result) {
        if (target == 0) {
            result.Add(new(current));
            return;
        }

        if (index < 0) {
            return;
        }

        if (target >= nums[index]) {
            current.Add(nums[index]);
            DFS(nums, index, target - nums[index], current, result);
            current.RemoveAt(current.Count - 1);
        }

        DFS(nums, index - 1, target, current, result);
    }

    public List<List<int>> CombinationSum(int[] nums, int target) {
        Array.Sort(nums);

        List<List<int>> result = [];
        DFS(nums, nums.Length - 1, target, [], result);

        return result;
    }
}
