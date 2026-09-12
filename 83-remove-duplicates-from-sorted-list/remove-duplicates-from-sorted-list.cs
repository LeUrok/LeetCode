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
    public ListNode DeleteDuplicates(ListNode head) {
        if (head != null && head.next != null)
        {
            ListNode? p = head;
            ListNode? q = (head.next != null) ? head.next : null;

            while (p != null)
            {
                while (q != null && p.val == q.val)
                    q = q.next;
                p.next = q;
                p = p.next;
            }
        }
        

        return head;
    }
}