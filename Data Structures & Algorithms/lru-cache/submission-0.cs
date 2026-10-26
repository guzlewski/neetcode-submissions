class Node {
    public Node Prev;
    public Node Next;
    public int Key;

    public Node(Node prev = null, Node next = null, int key = -1) {
        Prev = prev;
        Next = next;
        Key = key;
    }
}

public class LRUCache {
    private readonly int capacity;
    private readonly Dictionary<int, (int value, Node node)> dict = [];

    private Node head = new();
    private Node bottom = new();

    public LRUCache(int capacity) {
        this.capacity = capacity;
        head.Next = bottom;
        bottom.Prev = head;
    }

    public int Get(int key) {
        if (!dict.TryGetValue(key, out var value)) {
            return -1;
        }

        Node prev = value.node.Prev;
        Node current = value.node;
        Node next = value.node.Next;

        prev.Next = next;
        next.Prev = prev;

        current.Prev = head;
        current.Next = head.Next;

        head.Next = current;
        current.Next.Prev = current;

        return value.value;
    }

    public void Put(int key, int value) {
        if (dict.ContainsKey(key)) {
            Node current = dict[key].node;

            current.Prev.Next = current.Next;
            current.Next.Prev = current.Prev;

            current.Prev = head;
            current.Next = head.Next;

            head.Next.Prev = current;
            head.Next = current;

            dict[key] = (value, current);
        } else if (dict.Count < capacity) {
            Node current = new(key: key);

            current.Prev = head;
            current.Next = head.Next;

            head.Next = current;
            current.Next.Prev = current;

            dict[key] = (value, current);
        } else {
            dict.Remove(bottom.Prev.Key);

            Node current = new(key: key);

            current.Prev = head;
            current.Next = head.Next;

            head.Next = current;
            current.Next.Prev = current;

            bottom.Prev.Prev.Next = bottom;
            bottom.Prev = bottom.Prev.Prev;

            dict[key] = (value, current);
        }
    }
}
