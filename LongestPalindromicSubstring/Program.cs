using System;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(LongestPalindrome(input));
        }

        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            int bestStartIndex = 0;
            int bestLength = 1;

            bool[,] isPalindrome = new bool[s.Length, s.Length];

            for (int endIndex = 1; endIndex < s.Length; endIndex++)
            {
                for (int startIndex = 0; startIndex < endIndex; startIndex++)
                {
                    bool isInnerWordPalindrome = isPalindrome[startIndex + 1, endIndex - 1] || endIndex - startIndex <= 2;

                    if (s[startIndex] == s[endIndex] && isInnerWordPalindrome)
                    {
                        isPalindrome[startIndex, endIndex] = true;

                        int currentLength = endIndex - startIndex + 1;

                        if (currentLength > bestLength)
                        {
                            bestStartIndex = startIndex;
                            bestLength = currentLength;
                        }
                    }
                }
            }

            return s.Substring(bestStartIndex, bestLength);
        }
    }
}
