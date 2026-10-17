public class MinStack {
    private Stack<(int Value, int Min)> stack = [];

    public MinStack() {}

    public void Push(int val) {
        int min = stack.Count == 0 ? val : Math.Min(val, stack.Peek().Min);

        stack.Push((val, min));
    }

    public void Pop() {
        stack.Pop();
    }

    public int Top() {
        return stack.Peek().Value;
    }

    public int GetMin() {
        return stack.Peek().Min;
    }
}
