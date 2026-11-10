public class Solution {
    private readonly Dictionary<char, string> letters = [];

    public List<string> LetterCombinations(string digits) {
        letters['2'] = "abc";
        letters['3'] = "def";
        letters['4'] = "ghi";
        letters['5'] = "jkl";
        letters['6'] = "mno";
        letters['7'] = "pqrs";
        letters['8'] = "tuv";
        letters['9'] = "wxyz";

        List<string> result = [];

        foreach (char digit in digits) {
            List<string> temp = [];

            foreach (var letter in letters[digit]) {
                foreach (var r in result.DefaultIfEmpty(string.Empty)) {
                    temp.Add(r + letter);
                }
            }

            result = temp;
        }

        return result;
    }
}
