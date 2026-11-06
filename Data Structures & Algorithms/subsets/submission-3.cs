public class Solution {
    private void DFS(int[] nums, int index, List<int> current, List<List<int>> result) {
        if (index == nums.Length) {
            result.Add(new(current));
            return;
        }

        current.Add(nums[index]);
        DFS(nums, index + 1, current, result);
        current.RemoveAt(current.Count - 1);

        DFS(nums, index + 1, current, result);
    }

    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = [];
        DFS(new HashSet<int>(nums).ToArray(), 0, [], result);

        return result;
    }
}
