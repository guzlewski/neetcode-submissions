public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder builder = new();

        foreach (var str in strs) {
            builder.Append(str.Length);
            builder.Append("|");
            builder.Append(str);
        }

        return builder.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = [];
        int start = 0, end = 0;

        while (end < s.Length) {
            while (end < s.Length && s[end] != '|') {
                end++;
            }

            int len = int.Parse(s[start..end]);

            result.Add(s[(end + 1)..(end + len + 1)]);
            end += len + 1;
            start = end;
        }

        return result;
    }
}
