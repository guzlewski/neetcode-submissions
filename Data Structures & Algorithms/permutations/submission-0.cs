public class Solution {
    private void Swap(int[] nums, int i, int j) {
        int tmp = nums[i];
        nums[i] = nums[j];
        nums[j] = tmp;
    }

    private void Permutate(int[] nums, int index, List<List<int>> result) {
        if (index == nums.Length - 1) {
            result.Add(nums.ToList());
            return;
        }

        for (int i = index; i < nums.Length; i++) {
            Swap(nums, index, i);
            Permutate(nums, index + 1, result);
            Swap(nums, i, index);
        }
    }

    public List<List<int>> Permute(int[] nums) {
        List<List<int>> result = [];
        Permutate(nums, 0, result);

        return result;
    }
}
