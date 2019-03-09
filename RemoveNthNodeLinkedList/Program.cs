using System;

namespace RemoveNthNodeLinkedList
{
    class Program
    {
        static void Main()
        {
            ListNode head = new ListNode(new int[] { 1, 2, 3, 4, 5 });
            int n = 2;

            RemoveNthFromEnd(head, n);

            PrintLinkedList(head);
        }

        private static void PrintLinkedList(ListNode head)
        {
            ListNode currentNode = head;

            while (currentNode != null)
            {
                Console.Write(currentNode.val);
                currentNode = currentNode.next;
            }
        }

        public static void RemoveNthFromEnd(ListNode head, int n)
        {
            int length = GetLinkedListLength(head);
            int searchedNodeIndex = length - n;

            if (searchedNodeIndex == 0)
            {
                head = head.next;

                return;
            }

            ListNode prevNode = GetNthNode(head, searchedNodeIndex - 1);

            if (n > 1)
            {
                ListNode nextNode = GetNthNode(head, searchedNodeIndex + 1);

                prevNode.next = nextNode;
            }
            else if (n == 1)
            {
                prevNode.next = null;
            }
        }

        private static ListNode GetNthNode(ListNode head, int searchedNodeIndex)
        {
            ListNode current = head;

            for (int i = 1; i <= searchedNodeIndex; i++)
            {
                current = current.next;
            }

            return current;
        }

        private static int GetLinkedListLength(ListNode head)
        {
            ListNode currentNode = head;
            int length = 1;

            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
                length++;
            }

            return length;
        }
    }
}
