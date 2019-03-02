using System;

namespace AllSubsetOfArray
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[] { 1, 2, 3 };
            PrintAllSubSet(arr);
        }

        static void PrintAllSubSet(int[] arr)
        {
            for (int subSetCount = 0; subSetCount <= arr.Length; subSetCount++)
            {
                int[] elements = new int[subSetCount];
                PrintAllNSubsetRecursion(arr, elements, subSetCount);

                Console.WriteLine();
            }
        }

        static void PrintAllNSubsetRecursion(int[] arr, int[] elements, int loopsCount, int currentLoop = 1, int prevIndex = 0)
        {
            if (loopsCount == 0)
            {
                Print(elements);
                return;
            }
            if (currentLoop > loopsCount)
            {
                Print(elements);
                return;
            }

            for (int index = prevIndex; index < arr.Length; index++)
            {
                elements[currentLoop - 1] = arr[index];
                PrintAllNSubsetRecursion(arr, elements, loopsCount, currentLoop + 1, index + 1);
            }
        }

        private static void Print(int[] arr)
        {
            Console.Write("{");

            for (int index = 0; index < arr.Length; index++)
            {
                if (index != 0)
                {
                    Console.Write(", ");
                }

                Console.Write(arr[index]);
            }

            Console.Write("}");
        }
    }
}
