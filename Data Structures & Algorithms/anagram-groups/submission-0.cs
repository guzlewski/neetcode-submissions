public class Solution {
    private string CreateLookup(string s)
    {
        int[] lookup = new int[26];

        foreach(var c in s)
        {
            lookup[c - 'a']++;
        }

        return string.Join(',', lookup.Select(x => x.ToString()));
    }

    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new();

        foreach(var str in strs)
        {
            var key = CreateLookup(str);
            if(dict.TryGetValue(key, out var list))
            {
                list.Add(str);
            }
            else 
            {
                dict[key] = [str];
            }
        }

        return [..dict.Values];
    }
}
