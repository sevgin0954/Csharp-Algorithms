using System;

namespace NQuinRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];

            SolveNQuinsProblem(matrix);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static bool SolveNQuinsProblem(int[,] matrix, int col = 0)
        {
            if (col == matrix.GetLength(1))
            {
                return true;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (IsSafe(matrix, row, col))
                {
                    matrix[row, col] = 1;

                    if (SolveNQuinsProblem(matrix, col + 1) == true)
                    {
                        return true;
                    }

                    matrix[row, col] = 0;
                }
            }

            return false;
        }

        private static bool IsSafe(int[,] matrix, int row, int col)
        {
            // Check diagonal on right
            /* Check this row on left side */
            for (int i = 0; i < col; i++)
                if (matrix[row, i] == 1)
                    return false;

            /* Check upper diagonal on left side */
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (matrix[i, j] == 1)
                    return false;

            /* Check lower diagonal on left side */
            for (int r = row, c = col; c >= 0 && r < matrix.GetLength(0); r++, c--)
                if (matrix[r, c] == 1)
                    return false;

            return true;
        }
    }
}
