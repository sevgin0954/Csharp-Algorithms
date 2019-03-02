using System;

namespace LargestSquareof1sInAMatrix
{
    class Program
    {
        static void Main()
        {
            int[,] matrix = new int[,]
            {
                { 1, 1, 0, 1, 0 },
                { 0, 1, 1, 1, 0 },
                { 1, 1, 1, 1, 0 },
                { 0, 1, 1, 1, 0 }
            };

            int result = GetBestSquare(matrix);

            Console.WriteLine(result * result);
        }

        static int GetBestSquare(int[,] matrix)
        {
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);

            int[,] cache = new int[rowsCount, colsCount];

            int bestCount = 0;

            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < colsCount; col++)
                {
                    int currentCount = GetBestSquareRecursion(matrix, cache, row, col);

                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                    }
                }
            }

            return bestCount;
        }

        static int GetBestSquareRecursion(int[,] matrix, int[,] cache, int currentIndexRow = 0, int currentIndexCol = 0)
        {
            if (currentIndexRow < 0 || currentIndexRow >= matrix.GetLength(0) 
                ||
                currentIndexCol < 0 || currentIndexCol >= matrix.GetLength(1))
            {
                return 0;
            }
            if (matrix[currentIndexRow, currentIndexCol] == 0)
            {
                return 0;
            }
            if (cache[currentIndexRow, currentIndexCol] != 0)
            {
                return cache[currentIndexRow, currentIndexCol];
            }

            int squareCount = Math.Min
                (
                    GetBestSquareRecursion(matrix, cache, currentIndexRow, currentIndexCol + 1),
                    Math.Min
                    (
                        GetBestSquareRecursion(matrix, cache, currentIndexRow + 1, currentIndexCol + 1),
                        GetBestSquareRecursion(matrix, cache, currentIndexRow + 1, currentIndexCol)
                    )
                ) + 1;

            cache[currentIndexRow, currentIndexCol] = squareCount;

            return squareCount;
        }
    }
}
