public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var cars = position.Zip(speed).OrderByDescending(x => x.First);
        Stack<double> stack = [];

        foreach (var (p, s) in cars) {
            double arrivalTime = (target - p) / (double)s;

            if (stack.Count == 0 || arrivalTime > stack.Peek()) {
                stack.Push(arrivalTime);
            }
        }

        return stack.Count;
    }
}
