using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickSort
{
    class Program
    {
        static void Main()
        {
            int[] nums = { 9, 8, 7, 6, 4, 5, 4, 3, 2, 1, 0, -1, 100 };
            QuickSort(nums, 0, nums.Length - 1);
            Console.Write(string.Join(" ", nums));
        }

        private static void QuickSort(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int middle = start + (end - start) / 2;

            List<int> smallerThanPivot = new List<int>();
            List<int> bigerThanPivot = new List<int>();

            int startIndex = start;

            for (int a = 0; a < arr.Length; a++)
            {
                if (a != middle)
                {
                    if (arr[a] < arr[middle])
                    {
                        smallerThanPivot.Add(arr[a]);
                    }
                    else
                    {
                        bigerThanPivot.Add(arr[a]);
                    }
                }
            }

            smallerThanPivot.Add(arr[middle]);
            int[] tempArr = smallerThanPivot.Concat(bigerThanPivot).ToArray();

            for (int a = 0; a < arr.Length; a++)
            {
                arr[a] = tempArr[a];
            }

            QuickSort(arr, start, middle);
            QuickSort(arr, middle + 1, end);
        }
    }
}
