public class Solution {
    public int HammingWeight(uint n) {
        return System.Numerics.BitOperations.PopCount(n);
    }
}
