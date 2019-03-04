using System;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int bestLen = LengthOfLongestSubstring(input);

            Console.WriteLine(bestLen);
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int bestLength = 0;

            Dictionary<char, int> charIndexPairs = new Dictionary<char, int>();

            int startIndex = 0;
            int currentLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];

                if (charIndexPairs.ContainsKey(currentChar) == false)
                {
                    charIndexPairs[currentChar] = i;
                    currentLength++;
                }
                else
                {
                    if (charIndexPairs[currentChar] >= startIndex)
                    {
                        currentLength = i - charIndexPairs[currentChar];
                        startIndex = charIndexPairs[currentChar] + 1;
                    }
                    else
                    {
                        currentLength++;
                    }

                    charIndexPairs[currentChar] = i;
                }

                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                }
            }

            return bestLength;
        }
    }
}
