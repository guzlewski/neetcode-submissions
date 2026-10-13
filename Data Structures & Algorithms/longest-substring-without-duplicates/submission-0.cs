public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int start = 0, longest = 0;
        HashSet<char> substring = [];

        foreach (var c in s) {
            if (!substring.Add(c)) {
                longest = Math.Max(longest, substring.Count);

                while (s[start] != c) {
                    substring.Remove(s[start]);
                    start++;
                }

                start++;
            }
        }

        return Math.Max(longest, substring.Count);
    }
}
