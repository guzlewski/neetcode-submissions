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
    private ListNode Split(ListNode head) {
        ListNode slow = head, fast = head;

        while (fast?.next?.next is not null) {
            slow = slow.next;
            fast = fast?.next?.next;
        }

        ListNode mid = slow.next;
        slow.next = null;

        return mid;
    }

    private ListNode Reverse(ListNode head) {
        ListNode prev = null, current = head;
        
        while (current is not null) {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }

    private void Merge(ListNode l1, ListNode l2) {
        ListNode current = l1;
        l1 = l1.next;

        while (l1 is not null && l2 is not null) {
            current.next = l2;
            l2 = l2.next;
            current = current.next;

            current.next = l1;
            l1 = l1.next;
            current = current.next;
        }

        if (l1 is not null) {
            current.next = l1;
        } else {
            current.next = l2;
        }
    }

    public void ReorderList(ListNode head) {
        ListNode l1 = head, l2 = Split(head);
        l2 = Reverse(l2);
        Merge(l1, l2);
    }
}
