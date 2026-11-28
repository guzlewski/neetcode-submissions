public class Solution {
    private void Permutate(int[] nums, int index, List<List<int>> result) {
        if (index == nums.Length - 1) {
            result.Add(nums.ToList());
            return;
        }

        for (int i = index; i < nums.Length; i++) {
            (nums[i], nums[index]) = (nums[index], nums[i]);
            Permutate(nums, index + 1, result);
            (nums[i], nums[index]) = (nums[index], nums[i]);
        }
    }

    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = [];
        Permutate(nums, 0, result);

        return result;
    }
}
