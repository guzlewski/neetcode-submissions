public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n + 1];

        for (int i = 1; i <= n; i++) {
            result[i] = (int)System.Numerics.BitOperations.PopCount((uint)i);
        }

        return result;
    }
}
