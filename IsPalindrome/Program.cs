using System;

namespace IsPalindrome
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(IsPalindrome(n));
        }

        public static bool IsPalindrome(int x)
        {
            string numberAsString = x.ToString();

            int startIndex = 0;
            int endIndex = numberAsString.Length - 1;

            while (startIndex < endIndex)
            {
                if (numberAsString[startIndex] != numberAsString[endIndex])
                {
                    return false;
                }

                startIndex++;
                endIndex--;
            }

            return true;
        }
    }
}
