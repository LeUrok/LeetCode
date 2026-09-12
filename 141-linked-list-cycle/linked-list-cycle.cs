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
        if (head?.next != null)
        {
            ListNode p = head;
            ListNode q = head.next;

            while (q != p)
            {
                if (q?.next == null) return false;
                q = q.next.next;
                p = p.next;

                
            }
            return true;
        }
        return false;
    }
}