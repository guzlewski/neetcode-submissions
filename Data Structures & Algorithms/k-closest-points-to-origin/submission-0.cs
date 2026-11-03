public class Solution {
    private int Distance(int[] point) {
        return point[0] * point[0] + point[1] * point[1];
    }

    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], int> queue = new();

        foreach (var point in points) {
            if (queue.Count < k) {
                queue.Enqueue(point, -Distance(point));
            } else if (queue.TryPeek(out int[] _, out int distance) &&
                       -distance > Distance(point)) {
                queue.Dequeue();
                queue.Enqueue(point, -Distance(point));
            }
        }

        List<int[]> result = [];
        while (queue.TryDequeue(out int[] p, out int _)) {
            result.Add(p);
        }

        return result.ToArray();
    }
}
