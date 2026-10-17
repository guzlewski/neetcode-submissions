public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = [];

        foreach (var c in s) {
            if (c == '[' || c == '{' || c == '(') {
                stack.Push(c);
                continue;
            }

            if (stack.Count == 0) {
                return false;
            }

            var open = stack.Pop();

            if ((c == ']' && open != '[') || (c == '}' && open != '{') ||
                (c == ')' && open != '(')) {
                return false;
            }
        }

        return stack.Count == 0;
    }
}
