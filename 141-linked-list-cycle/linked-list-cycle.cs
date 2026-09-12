/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head != null && head.next != null)
        {
            ListNode p = head;
            ListNode q = head;

            while (q != null && q.next != null)
            {
                q = q.next.next;
                p = p.next;

                if (p == q)
                    return true;
            }
        }
        return false;
    }
}