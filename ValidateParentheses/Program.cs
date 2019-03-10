using System;
using System.Collections.Generic;

namespace ValidateParentheses
{
    class Program
    {
        static void Main()
        {
            string input = "([])";

            Console.WriteLine(IsValid(input));
        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> closingOpeningParentheses = new Dictionary<char, char>();
            closingOpeningParentheses[')'] = '(';
            closingOpeningParentheses['}'] = '{';
            closingOpeningParentheses[']'] = '[';

            foreach (var ch in s)
            {
                // Check is it closing parentheses
                if (closingOpeningParentheses.ContainsKey(ch) == true)
                {
                    var lastParentheses = ' ';
                    var isSuccessfull = stack.TryPop(out lastParentheses);

                    if (isSuccessfull == false || closingOpeningParentheses[ch] != lastParentheses)
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(ch);
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
