using System;
using System.Collections.Generic;

namespace FindPairWithSum
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[] { -1, -2, -3, -4, -5 };
            int targetSum = -8;

            int[] result = TwoSum(nums, targetSum);
            Console.WriteLine(string.Join(" ", result));
        }

        public static int[] TwoSum(int[] nums, int targetSum)
        {
            Dictionary<int, int> sumIndexPairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int difference = targetSum - nums[i];

                if (sumIndexPairs.ContainsKey(nums[i]) == true)
                {
                    return new int[] { sumIndexPairs[nums[i]], i };
                }
                else
                {
                    sumIndexPairs[difference] = i;
                }
            }

            return null;
        }
    }
}
