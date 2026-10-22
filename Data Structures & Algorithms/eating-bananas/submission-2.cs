public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1, right = int.MaxValue - 1;

        while (left < right) {
            int mid = left + (right - left) / 2;
            int time = (int)piles.Select(x => Math.Ceiling(x / (double)mid)).Sum();

            if (time > h) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }

        return left;
    }
}
