public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) {
            return false;
        }

        int[] window = new int[26], template = new int[26];

        for (int i = 0; i < s1.Length; i++) {
            template[s1[i] - 'a']++;
            window[s2[i] - 'a']++;
        }

        for (int i = s1.Length; i < s2.Length; i++) {
            if (window.SequenceEqual(template)) {
                break;
            }

            window[s2[i - s1.Length] - 'a']--;
            window[s2[i] - 'a']++;
        }

        return window.SequenceEqual(template);
    }
}
