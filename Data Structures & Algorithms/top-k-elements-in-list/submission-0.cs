public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new(nums.CountBy(n => n));
        PriorityQueue<int, int> queue = new();

        foreach (var kp in dict) {
            queue.Enqueue(kp.Key, -kp.Value);
        }

        int[] result = new int[k];

        for (int i = 0; i < k; i++) {
            result[i] = queue.Dequeue();
        }

        return result;
    }
}
