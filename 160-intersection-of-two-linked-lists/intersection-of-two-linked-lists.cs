/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if (headA == null || headB == null) return null;

        ListNode a = headA;
        ListNode b = headB;
        int c = 0;
        int is_a_bigger = 0;
        while (a != null && b != null)
        {
            a = a.next;
            b = b.next;
        }
        if (a == null)
        {
            while (b != null)
            {
                b = b.next;
                c++;
            }
        }
        else
        {
            is_a_bigger = 1;
            while (a != null)
            {
                a = a.next;
                c++;

            }
        }
        a = headA;
        b = headB;
        if (is_a_bigger == 1)
        {
            while(c != 0)
            {
                a = a.next;
                c--;
            }
        }
        else
        {
            while(c != 0)
            {
                b = b.next;
                c--;
            }
        }
        while(a != null)
        {
            if (a == b)
                return a;
            a = a.next;
            b = b.next;
        }
        return null;

    }
}