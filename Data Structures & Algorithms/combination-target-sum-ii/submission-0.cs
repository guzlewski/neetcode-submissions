public class Solution {
    private void DFS(int[] candidates, int target, int index, List<int> current,
                     List<List<int>> result) {
        if (target == 0) {
            result.Add(new(current));
            return;
        } else if (target < 0 || index < 0) {
            return;
        }

        current.Add(candidates[index]);
        DFS(candidates, target - candidates[index], index - 1, current, result);
        current.RemoveAt(current.Count - 1);

        while (index > 0 && candidates[index - 1] == candidates[index]) {
            index--;
        }

        if (index >= 0) {
            DFS(candidates, target, index - 1, current, result);
        }
    }

    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);

        List<List<int>> result = [];
        DFS(candidates, target, candidates.Length - 1, [], result);

        return result;
    }
}
