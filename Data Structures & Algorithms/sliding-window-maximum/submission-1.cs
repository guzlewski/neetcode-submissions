public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if(k == 1) {
            return nums;
        }

        List<int> result = [];
        Dictionary<int, int> window = new(nums[0..k].CountBy(x => x));
        PriorityQueue<int, int> queue = new();

        for (int i = 0; i < k; i++) {
            queue.Enqueue(nums[i], -nums[i]);
        }

        for (int i = k; i < nums.Length; i++) {
            int max = queue.Peek();
            result.Add(max);

            window[nums[i - k]]--;
            while (window[queue.Peek()] == 0) {
                queue.Dequeue();
            }

            if (!window.ContainsKey(nums[i])) {
                window[nums[i]] = 0;
            }

            window[nums[i]]++;
            queue.Enqueue(nums[i], -nums[i]);
        }

        result.Add(queue.Peek());

        return result.ToArray();
    }
}
