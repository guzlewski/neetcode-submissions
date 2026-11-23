public class Solution {
    private Dictionary<int, int> cache = [];

    public int ClimbStairs(int n) {
        if (n <= 1) {
            return 1;
        }

        if (cache.ContainsKey(n)) {
            return cache[n];
        }

        cache[n] = ClimbStairs(n - 1) + ClimbStairs(n - 2);

        return cache[n];
    }
}
