public class Solution {
    private string CreateKey(string s) {
        int[] lookup = new int[26];

        foreach (var c in s) {
            lookup[c - 'a']++;
        }

        return string.Join(',', lookup.Select(x => x.ToString()));
    }

    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new();

        foreach (var str in strs) {
            var key = CreateKey(str);
            if (!dict.ContainsKey(key)) {
                dict[key] = [];
            }

            dict[key].Add(str);
        }

        return [..dict.Values];
    }
}
