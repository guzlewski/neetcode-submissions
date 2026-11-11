public class Solution {
    public void Generate(int n, int open, int close, List<char> current, List<string> result) {
        if (open == n && close == n) {
            result.Add(string.Join("", current));
            return;
        }

        if (open > close) {
            current.Add(')');
            Generate(n, open, close + 1, current, result);
            current.RemoveAt(current.Count - 1);
        }

        if (open < n) {
            current.Add('(');
            Generate(n, open + 1, close, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }

    public List<string> GenerateParenthesis(int n) {
        List<string> result = [];

        Generate(n, 0, 0, [], result);

        return result;
    }
}
