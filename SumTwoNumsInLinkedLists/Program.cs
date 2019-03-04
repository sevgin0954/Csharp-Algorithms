using System;

namespace SumTwoNumsInLinkedLists
{
    class Program
    {
        static void Main()
        {
            ListNode l1 = new ListNode(2, 4, 3);
            ListNode l2 = new ListNode(5, 6, 4);

            var result = AddTwoNumbers(l1, l2);

            Print(result);
        }

        private static void Print(ListNode list)
        {
            ListNode current = list;

            while (current != null)
            {
                Console.Write(current.val);
                current = current.next;
            }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var headNode = new ListNode(0);
            var currentNode = headNode;

            var l1CurrentNode = l1;
            var l2CurrentNode = l2;

            int left = 0;

            while (l1CurrentNode != null || l2CurrentNode != null)
            {
                int num1 = (l1CurrentNode == null) ? 0 : l1CurrentNode.val;
                int num2 = (l2CurrentNode == null) ? 0 : l2CurrentNode.val;

                int sum = num1 + num2;
                sum += left;

                left = sum / 10;
                sum %= 10;
                
                currentNode.next = new ListNode(sum);
                currentNode = currentNode.next;

                if (l1CurrentNode != null)
                {
                    l1CurrentNode = l1CurrentNode.next;
                }
                if (l2CurrentNode != null)
                {
                    l2CurrentNode = l2CurrentNode.next;
                }
            }

            while (left > 0)
            {
                currentNode.next = new ListNode(left % 10);
                currentNode = currentNode.next;

                left /= 10;
            }

            return headNode.next;
        }
    }
}
