public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1, right = piles.Max();

        while (left <= right) {
            int mid = left + (right - left) / 2;
            int time = (int)piles.Select(x => Math.Ceiling(x / (double)mid)).Sum();

            if (time > h) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return left;
    }
}
