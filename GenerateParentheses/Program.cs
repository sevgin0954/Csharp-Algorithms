using System;
using System.Linq;
using System.Collections.Generic;

namespace GenerateParentheses
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var result = GenerateParenthesis(n);

            Print(result);
        }

        public static IList<string> GenerateParenthesis(int n)
        {
            IList<string> allParenthesis = new List<string>();

            GenerateAll(allParenthesis, new char[n * 2]);

            return allParenthesis;
        }

        public static void GenerateAll(
            IList<string> allParenthesis, 
            char[] arr,  
            int currentIndex = 0, 
            int openCount = 0, 
            int closeCount = 0)
        {
            if (currentIndex == arr.Length)
            {
                allParenthesis.Add(string.Join("", arr));

                return;
            }

            if (openCount < arr.Length / 2)
            {
                arr[currentIndex] = '(';

                GenerateAll(allParenthesis, arr, currentIndex + 1, openCount + 1, closeCount);
            }
            if (closeCount < openCount)
            {
                arr[currentIndex] = ')';

                GenerateAll(allParenthesis, arr, currentIndex + 1, openCount, closeCount + 1);
            }
        }

        private static void Print(IList<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
