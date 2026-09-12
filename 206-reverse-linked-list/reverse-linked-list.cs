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
    public ListNode ReverseList(ListNode head) {
        if (head == null) return null;

        if (head.next != null)
        {
            ListNode prev = null;
            ListNode cur = head;
            ListNode tmp = cur;

            while (cur.next != null)
            {
                tmp = cur.next;
                cur.next = prev;
                prev = cur;
                cur = tmp;
            }
            cur.next = prev;
            head = cur;
        }
        
        
        return head;
    }
}