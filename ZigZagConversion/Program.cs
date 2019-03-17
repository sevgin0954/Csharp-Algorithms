using System;
using System.Collections.Generic;
using System.Text;

namespace ZigZagConversion
{
    class Program
    {
        static void Main()
        {
            string input = "PAYPALISHIRING";
            int n = 3;

            Console.WriteLine(Convert(input, n));
        }

        public static string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            List<StringBuilder> rows = new List<StringBuilder>();
            for (int row = 0; row < numRows; row++)
            {
                rows.Add(new StringBuilder());
            }

            bool movingDown = false;
            int currentRow = 0;

            foreach (var ch in s)
            {
                rows[currentRow].Append(ch);

                if (currentRow == 0 || currentRow == numRows - 1)
                {
                    movingDown = !movingDown;
                }

                currentRow += movingDown == true ? 1 : -1;
            }

            StringBuilder result = new StringBuilder();
            foreach (var row in rows)
            {
                result.Append(row.ToString());
            }

            return result.ToString();
        }
    }
}
