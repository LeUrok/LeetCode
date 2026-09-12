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
    public ListNode MiddleNode(ListNode head) {
        ListNode p = head;
        ListNode q = head;

        while (q != null && q.next != null)
        {
            p = p.next;
            q = q.next.next;
        }

        return p;
    }
}