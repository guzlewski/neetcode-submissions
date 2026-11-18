public class Solution {
    public int[] PlusOne(int[] digits) {
        Stack<int> result = [];
        int carry = 1;

        for (int i = digits.Length - 1; i >= 0; i--) {
            int digit = digits[i] + carry;

            result.Push(digit % 10);
            carry = digit / 10;
        }

        if (carry != 0) {
            result.Push(carry);
        }

        return result.ToArray();
    }
}
