public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] window = new int[26];
        int start = 0, max = 0, maxf = 0;

        for (int end = 0; end < s.Length; end++) {
            window[s[end] - 'A']++;
            maxf = Math.Max(maxf, window[s[end] - 'A']);

            while (end - start + 1 - maxf > k) {
                window[s[start] - 'A']--;
                start++;
            }

            max = Math.Max(max, end - start + 1);
        }

        return max;
    }
}
