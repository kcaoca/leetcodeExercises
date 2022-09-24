/**https://leetcode.com/problems/remove-nth-node-from-end-of-list/submissions/
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
        Queue<int> store = new Queue<int>();
        int count = 0;
        while (head != null) {
            store.Enqueue(head.val);
            count++;
            head = head.next;
        }
        ListNode res = new ListNode();
        head = new ListNode(0, res);
        int i = 0;
        while (store.Count > 0) {
            if (i++ == count - n)
                store.Dequeue();
            else {
                res.next = new ListNode(store.Dequeue());
                res = res.next;
            }
        }
        return head.next.next;
    }
}
/*Runtime: 151 ms, faster than 24.78% of C# online submissions for Remove Nth Node From End of List.
Memory Usage: 37.6 MB, less than 80.19% of C# online submissions for Remove Nth Node From End of List.
*/

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        Dictionary<int, ListNode> dict = new Dictionary<int, ListNode>();
        int count = 0;
        while (head != null) {
            dict.Add(count++, head);
            head = head.next;
        }
        if (n == 1) {
            if (count <= 1)
                return null;
            else {
                dict[count - 2].next = null;
                return dict[0];
            }
        } else if (n == count) {
            if (count <= 1)
                return null;
            else
                return dict[1];
        }
        dict[count - n - 1].next = dict[count - n + 1];
        return dict[0];
    }
}
/*Runtime: 153 ms, faster than 21.73% of C# online submissions for Remove Nth Node From End of List.
Memory Usage: 37.6 MB, less than 90.01% of C# online submissions for Remove Nth Node From End of List.
*/

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode[] dict = new ListNode[30];
        int count = 0;
        while (head != null) {
            dict[count++] = head;
            head = head.next;
        }
        if (n == 1) {
            if (count <= 1)
                return null;
            else {
                dict[count - 2].next = null;
                return dict[0];
            }
        } else if (n == count) {
            if (count <= 1)
                return null;
            else
                return dict[1];
        }
        dict[count - n - 1].next = dict[count - n + 1];
        return dict[0];
    }
}
/*Runtime: 146 ms, faster than 31.26% of C# online submissions for Remove Nth Node From End of List.
Memory Usage: 37.9 MB, less than 51.23% of C# online submissions for Remove Nth Node From End of List.
*/

