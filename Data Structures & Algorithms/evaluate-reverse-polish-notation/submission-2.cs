public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> values = [];

        foreach (var token in tokens) {
            if (int.TryParse(token, out int number)) {
                values.Push(number);
                continue;
            }

            int right = values.Pop();
            int left = values.Pop();
            int result;

            if (token == "+") {
                result = left + right;
            } else if (token == "-") {
                result = left - right;
            } else if (token == "*") {
                result = left * right;
            } else {
                result = left / right;
            }

            values.Push(result);
        }

        return values.Pop();
    }
}
