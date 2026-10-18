public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] result = new int[temperatures.Length];
        Stack<(int temp, int index)> stack = [];

        for (int i = 0; i < temperatures.Length; i++) {
            while (stack.Count != 0 && stack.Peek().temp < temperatures[i]) {
                result[stack.Peek().index] = i - stack.Peek().index;
                stack.Pop();
            }

            stack.Push((temperatures[i], i));
        }

        return result;
    }
}
