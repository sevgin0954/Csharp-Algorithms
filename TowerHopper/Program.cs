using System;

namespace TowerHopper
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[] { 4, 2, 4, 2, 2, 0, 5 };
            Console.WriteLine(IsHoppable(arr));
        }

        static bool IsHoppable(int[] arr, int prevIndex = 0, int currentIndex = 0)
        {
            if (IsJumpPossible(arr, prevIndex, currentIndex) == false)
            {
                return false;
            }
            if (currentIndex >= arr.Length - 1)
            {
                return true;
            }

            for (int jumpCount = 1; jumpCount <= arr[currentIndex]; jumpCount++)
            {
                if (IsHoppable(arr, currentIndex, currentIndex + jumpCount))
                {
                    return true;
                }
            }

            return false;
        }

        static bool IsJumpPossible(int[] arr, int startIndex, int endIndex)
        {
            if (endIndex >= arr.Length)
            {
                endIndex = arr.Length - 1;
            }

            for (int index = startIndex + 1; index <= endIndex; index++)
            {
                if (arr[startIndex] < arr[index])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
