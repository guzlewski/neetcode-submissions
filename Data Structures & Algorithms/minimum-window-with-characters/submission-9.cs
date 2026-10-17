public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> window = [], needed = new(t.CountBy(x => x));
        int fulfilled = 0, start = 0, tDistinctLen = t.ToCharArray().Distinct().Count();
        ReadOnlySpan<char> shortest = [];

        foreach (var c in (s + t).ToCharArray().Distinct()) {
            window[c] = 0;

            if (!needed.ContainsKey(c)) {
                needed[c] = 0;
            }
        }

        for (int end = 0; end < s.Length; end++) {
            window[s[end]]++;

            if (needed[s[end]] != 0 && window[s[end]] == needed[s[end]]) {
                fulfilled++;
            }

            while (fulfilled == tDistinctLen) {
                if (shortest.Length == 0 || shortest.Length > end - start) {
                    shortest = s.AsSpan(start..(end + 1));
                }

                window[s[start]]--;

                if (window[s[start]] + 1 == needed[s[start]]) {
                    fulfilled--;
                }

                start++;
            }
        }

        return shortest.ToString();
    }
}
