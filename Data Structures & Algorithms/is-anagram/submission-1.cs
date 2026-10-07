public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> dict = new(s.CountBy(c => c));

        foreach (var kp in t.CountBy(c => c)) {
            if (!dict.TryGetValue(kp.Key, out var val) || val != kp.Value) {
                return false;
            }
        }

        return true;
    }
}
