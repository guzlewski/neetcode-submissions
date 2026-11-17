public class Solution {
    public int Reverse(int x) {
        if (x == int.MinValue) {
            return 0;
        }

        int value = Math.Abs(x), result = 0;

        while (value != 0) {
            int tmp = result;
            result *= 10;
            result += value % 10;

            if (tmp != ((result - (value % 10)) / 10)) {
                return 0;
            }

            value /= 10;
        }

        return x > 0 ? result : -result;
    }
}
