using System;

namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(BinarySearch(arr, 3, 0, arr.Length - 1));
        }

        static int BinarySearch(int[] arr, int searchedNum, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                return -1;
            }

            int mid = (startIndex + endIndex) / 2;

            if (arr[mid] == searchedNum)
            {
                return mid;
            }

            if (arr[mid] > searchedNum)
            {
                return BinarySearch(arr, searchedNum, startIndex, mid - 1);
            }

            return BinarySearch(arr, searchedNum, mid + 1, endIndex);
        }
    }
}
