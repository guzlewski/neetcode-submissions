public class KthLargest {
    private readonly int k;
    private readonly PriorityQueue<int, int> queue = new();

    public KthLargest(int k, int[] nums) {
        this.k = k;
        foreach (var num in nums) {
            queue.Enqueue(num, num);

            if (queue.Count > k) {
                queue.Dequeue();
            }
        }
    }

    public int Add(int val) {
        if (queue.Count < k) {
            queue.Enqueue(val, val);
        } else if (val > queue.Peek()) {
            queue.Dequeue();
            queue.Enqueue(val, val);
        }

        return queue.Peek();
    }
}
