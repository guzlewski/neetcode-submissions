/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        ListNode root = new();
        ListNode current = root;

        PriorityQueue<ListNode, int> queue = new();

        foreach (var list in lists) {
            if (list is not null) {
                queue.Enqueue(list, list.val);
            }
        }

        while (queue.Count != 0) {
            ListNode node = queue.Dequeue();

            if (node.next is not null) {
                queue.Enqueue(node.next, node.next.val);
            }

            current.next = node;
            current = current.next;
        }

        return root.next;
    }
}
