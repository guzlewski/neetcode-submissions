public class Solution {
    private int SumOfSquares(int x) {
        int sum = 0;

        while (x != 0) {
            int digit = x % 10;
            sum += digit * digit;
            x /= 10;
        }

        return sum;
    }

    public bool IsHappy(int n) {
        int sum = 0;
        HashSet<int> seen = [];

        for (int i = 0; i < 1000; i++) {
            sum = SumOfSquares(n);

            if (sum == 1) {
                break;
            }

            if (!seen.Add(sum)) {
                return false;
            }

            n = sum;
        }

        return sum == 1;
    }
}
