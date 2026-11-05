public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        PriorityQueue<int, int> backlog =
            new(tasks.CountBy(c => c).Select(kp => (kp.Value, -kp.Value)));
        Queue<(int task, int minTime)> cooldown = [];
        int time = 0;

        while (backlog.Count != 0 || cooldown.Count != 0) {
            if (backlog.TryDequeue(out int task, out int _)) {
                if (task > 1) {
                    cooldown.Enqueue((task - 1, time + n));
                }
            }

            if (cooldown.Count > 0 && cooldown.Peek().minTime <= time) {
                backlog.Enqueue(cooldown.Peek().task, -cooldown.Peek().task);
                cooldown.Dequeue();
            }

            time++;
        }

        return time;
    }
}
