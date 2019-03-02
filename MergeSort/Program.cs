using System;

namespace MergeSort
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[] { 6, 4, 3, 7, -2, 505, 5, 1, 2 };

            MergeSort(arr, 0, arr.Length - 1);

            Console.WriteLine(string.Join(" ", arr));
        }

        private static void MergeSort(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int middle = (startIndex + endIndex) / 2;

            MergeSort(arr, startIndex, middle);
            MergeSort(arr, middle + 1, endIndex);
            
            CompareAndSort(arr, startIndex, middle, endIndex);
        }

        private static void CompareAndSort(int[] arr, int startIndex, int middle, int endIndex)
        {
            int[] sortedArr = new int[endIndex - startIndex + 1];
            int sortedArrIndex = 0;
            int leftIndex = startIndex;
            int rigthIndex = middle + 1;

            while (leftIndex <= middle && rigthIndex <= endIndex)
            {
                if (arr[leftIndex] > arr[rigthIndex])
                {
                    sortedArr[sortedArrIndex++] = arr[rigthIndex++];
                }
                else
                {
                    sortedArr[sortedArrIndex++] = arr[leftIndex++];
                }
            }

            while (leftIndex <= middle)
            {
                sortedArr[sortedArrIndex++] = arr[leftIndex++];
            }

            while (rigthIndex <= endIndex)
            {
                sortedArr[sortedArrIndex++] = arr[rigthIndex++];
            }

            sortedArrIndex = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                arr[i] = sortedArr[sortedArrIndex++];
            }
        }
    }
}