using System.Linq;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(params int[] nums)
    {
        AddNodes(nums);
    }

    private void AddNodes(int[] nums)
    {
        this.val = nums[0];

        if (nums.Length > 1)
        {
            this.next = new ListNode(nums.Skip(1).ToArray());
        }
    }
}