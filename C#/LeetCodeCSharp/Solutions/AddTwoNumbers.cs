namespace LeetCodeCSharp.Solutions;

// https://leetcode.com/problems/add-two-numbers/
// Add two numbers represented as reversed linked lists, return the sum as a linked list.
// Time: O(max(m,n)), Space: O(max(m,n))
public class AddTwoNumbers
{
    public ListNode Solve(ListNode l1, ListNode l2)
    {
        var dummy = new ListNode(0);
        var current = dummy;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int sum = carry;
            if (l1 != null) { sum += l1.val; l1 = l1.next; }
            if (l2 != null) { sum += l2.val; l2 = l2.next; }

            carry = sum / 10;
            current.next = new ListNode(sum % 10);
            current = current.next;
        }

        return dummy.next!;
    }
}

public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;

    public static ListNode From(params int[] values)
    {
        var dummy = new ListNode();
        var current = dummy;
        foreach (int v in values) { current.next = new ListNode(v); current = current.next; }
        return dummy.next!;
    }

    public override string ToString()
    {
        var parts = new List<string>();
        for (var node = this; node != null; node = node.next)
            parts.Add(node.val.ToString());
        return $"[{string.Join(", ", parts)}]";
    }
}
