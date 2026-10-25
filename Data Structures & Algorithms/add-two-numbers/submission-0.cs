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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode root = new(), current = root;

        int carry = 0;
        while (l1 is not null || l2 is not null || carry != 0) {
            int result = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            carry = result / 10;
            result %= 10;

            current.next = new(result);
            current = current.next;

            if (l1 is not null) {
                l1 = l1.next;
            }

            if (l2 is not null) {
                l2 = l2.next;
            }
        }

        return root.next;
    }
}
