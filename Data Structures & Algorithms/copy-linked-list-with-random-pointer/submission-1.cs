/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head is null) {
            return null;
        }

        Dictionary<Node, Node> nodes = [];

        Node current = head, prev = null;
        while (current is not null) {
            nodes[current] = new(current.val);

            if (prev is not null) {
                nodes[prev].next = nodes[current];
            }

            prev = current;
            current = current.next;
        }

        current = head;
        while (current is not null) {
            if (current.random is not null) {
                nodes[current].random = nodes[current.random];
            }

            current = current.next;
        }

        return nodes[head];
    }
}
