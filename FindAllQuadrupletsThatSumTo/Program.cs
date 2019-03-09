using System;
using System.Collections.Generic;
using System.Linq;

namespace FindAllQuadrupletsThatSumTo
{
    class Program
    {
        static void Main()
        {
            int targetSum = 0;
            int[] nums = new int[] { 1, 0, -1, 0, -2, 2 };

            var result = FourSum(nums, targetSum);

            Print(result);
        }

        public static IList<IList<int>> FourSum(int[] nums, int targetSum)
        {
            int combinationsCount = 4;
            var allCombinations = new List<IList<int>>();

            GenerateAllUniqueCombination(nums, combinationsCount, new int[combinationsCount], allCombinations);

            allCombinations = allCombinations
                .Where(list => list.Sum() == targetSum)
                .ToList();

            return allCombinations;
        }

        private static void GenerateAllUniqueCombination(int[] nums, int depth, int[] arr, IList<IList<int>> output, int index = 0)
        {
            if (depth == 0)
            {
                output.Add(arr.ToList());

                return;
            }

            for (int i = index; i < nums.Length; i++)
            {
                arr[depth - 1] = nums[i];

                GenerateAllUniqueCombination(nums, depth - 1, arr, output, i + 1);
            }
        }

        private static void Print(IList<IList<int>> lists)
        {
            foreach (var list in lists)
            {
                Console.WriteLine(string.Join(", ", list));
            }
        }
    }
}
