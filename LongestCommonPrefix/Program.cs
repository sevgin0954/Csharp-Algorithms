using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main()
        {
            string[] words = new string[] { "" };

            Console.WriteLine(LongestCommonPrefix(words));
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = "";

            if (strs.Length == 0)
            {
                return prefix;
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }

            int wordIndex = 0;

            while (true)
            {
                for (int i = 0; i < strs.Length - 1; i++)
                {
                    string currentWord = strs[i];
                    string nextWord = strs[i + 1];

                    if (currentWord.Length <= wordIndex)
                    {
                        return prefix;
                    }
                    if (nextWord.Length <= wordIndex)
                    {
                        return prefix;
                    }

                    if (currentWord[wordIndex] != nextWord[wordIndex])
                    {
                        return prefix;
                    }
                }

                prefix = strs[0].Substring(0, wordIndex + 1);

                wordIndex++;
            }
        }
    }
}
