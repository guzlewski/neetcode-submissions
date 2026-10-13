public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] window = new int[26];
        int start = 0, max = 0;

        for (int end = 0; end < s.Length; end++) {
            window[s[end] - 'A']++;

            while (window.Sum() - window.Max() > k) {
                window[s[start] - 'A']--;
                start++;
            }

            max = Math.Max(max, end - start + 1);
        }

        return Math.Max(max, 0);
    }
}
