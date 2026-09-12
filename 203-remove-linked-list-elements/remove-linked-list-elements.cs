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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode prev = head;

        while (prev != null && prev.val == val)
        {
            prev = prev.next;
            head = head.next;
        }

        if (prev == null)
            return null;
        
        ListNode cur = prev.next;

        while (cur != null)
        {
            if (cur.val == val)
            {
                prev.next = cur.next;
                cur = cur.next;
            }
            else
            {
                cur = cur.next;
                prev = prev.next;    
            }
            
        }

        

        return head;
    }
}