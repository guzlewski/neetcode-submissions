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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode current = head;
        int count = 0;

        while (current is not null) {
            current = current.next;
            count++;
        }

        int index = count - n;
        if (index == 0) {
            return head.next;
        }

        current = head;
        while (index > 1) {
            current = current.next;
            index--;
        }

        current.next = current.next?.next;

        return head;
    }
}
