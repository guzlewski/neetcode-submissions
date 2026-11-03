public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> queue = new(stones.Select(s => (s, -s)));

        while (queue.Count > 1) {
            int result = queue.Dequeue() - queue.Dequeue();

            if (result != 0) {
                queue.Enqueue(result, -result);
            }
        }

        return queue.Count != 0 ? queue.Peek() : 0;
    }
}
