using System;
using System.Linq;

namespace MergeTwoSortedLists
{
    class Program
    {
        static void Main()
        {
            int[] l1Nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] l2Nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            ListNode l1 = new ListNode(l1Nums);
            ListNode l2 = new ListNode(l2Nums);

            ListNode result = MergeTwoLists(l1, l2);

            Console.WriteLine(result.ToString());
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode mergetCurrent = head;

            ListNode l1Current = l1;
            ListNode l2Current = l2;

            while (l1Current != null && l2Current != null)
            {
                mergetCurrent.next = new ListNode(0);
                mergetCurrent = mergetCurrent.next;

                if (l1Current.val > l2Current.val)
                {
                    mergetCurrent.val = l2Current.val;
                    l2Current = l2Current.next;
                }
                else
                {
                    mergetCurrent.val = l1Current.val;
                    l1Current = l1Current.next;
                }
            }

            if (l1Current != null)
            {
                AddToList(head, l1Current);
            }
            if (l2Current != null)
            {
                AddToList(head, l2Current);
            }

            return head.next;
        }

        private static void AddToList(ListNode l1, ListNode l2)
        {
            ListNode l1End = GetLastNode(l1);

            while (l2 != null)
            {
                l1End.next = new ListNode(l2.val);
                l1End = l1End.next;
                l2 = l2.next;
            }
        }

        private static ListNode GetLastNode(ListNode head)
        {
            while (head.next != null)
            {
                head = head.next;
            }

            return head;
        }
    }
}
