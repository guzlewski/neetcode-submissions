class Node {
    public int Timestamp { get; init; } = int.MaxValue;
    public string Value { get; init; } = string.Empty;
    public Node Next { get; set; }
}

public class TimeMap {
    private Dictionary<string, Node> roots = [];

    public void Set(string key, string value, int timestamp) {
        if (!roots.ContainsKey(key)) {
            roots[key] = new();
        }

        Node prev = null, current = roots[key],
             node = new() { Timestamp = timestamp, Value = value };

        while (current is not null && current.Timestamp > node.Timestamp) {
            prev = current;
            current = current.Next;
        }

        prev.Next = node;
        node.Next = current;
    }

    public string Get(string key, int timestamp) {
        if (!roots.ContainsKey(key)) {
            return string.Empty;
        }

        Node current = roots[key];

        while (current.Next is not null && current.Timestamp > timestamp) {
            current = current.Next;
        }

        return current.Timestamp <= timestamp ? current.Value : string.Empty;
    }
}
