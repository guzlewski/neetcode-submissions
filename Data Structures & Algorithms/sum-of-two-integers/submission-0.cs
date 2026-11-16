public class Solution {
    public int GetSum(int a, int b) {
        int sum = 0, carry = 0;

        for (int i = 0; i < 32; i++) {
            int left = a & 1, right = b & 1, result = 0;

            if (left == 1 && right == 1) {
                if (carry == 1) {
                    result = 1;
                    carry = 1;
                } else {
                    result = 0;
                    carry = 1;
                }
            } else if (left == 1 || right == 1) {
                if (carry == 1) {
                    result = 0;
                    carry = 1;
                } else {
                    result = 1;
                    carry = 0;
                }
            } else {
                if (carry == 1) {
                    result = 1;
                    carry = 0;
                } else {
                    result = 0;
                    carry = 0;
                }
            }

            sum = sum | (result << i);

            a >>= 1;
            b >>= 1;
        }

        return sum;
    }
}
