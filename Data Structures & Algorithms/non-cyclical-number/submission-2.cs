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
        HashSet<int> seen = [];

        while (!seen.Contains(n)) {
            seen.Add(n);
            n = SumOfSquares(n);
            
            if (n == 1) {
                return true;
            }
        }

        return false;
    }
}
