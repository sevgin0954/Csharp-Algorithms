using System;

class Program
{
    static bool IsSubsetSum(int[] arr, int n, int sum)
    {
        if (sum == 0)
        {
            return true;
        }
        if (n == 0)
        {
            return false;
        }

        if (arr[n - 1] > sum)
        {
            return IsSubsetSum(arr, n - 1, sum);
        }

        return IsSubsetSum(arr, n - 1, sum) || IsSubsetSum(arr, n - 1, sum - arr[n - 1]);
    }

    public static void Main()
    {
        int[] arr = { 3, 34, 4, 12, 5, 2 };
        int sum = 9;

        if (IsSubsetSum(arr, arr.Length, sum) == true)
        {
            Console.WriteLine("Found a subset with given sum");
        }
        else
        {
            Console.WriteLine("No subset with given sum");
        }
    }
}