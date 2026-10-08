public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new(nums.CountBy(n => n));
        List<int>[] freq = new List<int>[nums.Length + 1];

        foreach (var kp in dict) {
            if (freq[kp.Value] is null) {
                freq[kp.Value] = [];
            }

            freq[kp.Value].Add(kp.Key);
        }

        List<int> result = [];

        for (int i = freq.Length - 1; i >= 0; i--) {
            if (freq[i] is not null)
                result.AddRange(freq[i]);

            if (result.Count == k)
                break;
        }

        return result.ToArray();
    }
}
