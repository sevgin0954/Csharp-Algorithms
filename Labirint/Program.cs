using System;

namespace Labirint
{
    class Program
    {
        static char[,] labirint = new char[,]
            {
                { ' ', ' ', ' ', 'x', ' ', ' ', ' ' },
                { 'x', 'x', ' ', 'x', 'x', 'x', ' ' },
                { 'x', ' ', ' ', 'x', 'x', 'x', ' ' },
                { 'x', ' ', 'x', 'x', ' ', ' ', ' ' },
                { 'x', ' ', 'x', 'x', ' ', 'x', ' ' },
                { ' ', ' ', 'x', 'x', ' ', 'x', ' ' },
                { 'x', ' ', ' ', ' ', ' ', ' ', ' ' },
                { 'x', ' ', 'x', 'x', 'x', 'x', ' ' },
                { 'x', ' ', 'x', 'x', 'x', 'x', 'f' }
            };

        static char[] path = new char[labirint.GetLength(0) * labirint.GetLength(1)];

        static int pathCurrentIndex = 0;

        static void Main(string[] args)
        {
            FindPathLabirint();
        }

        static void FindPathLabirint(int row = 0, int col = 0, char direction = 'R')
        {
            if (col < 0 || col == labirint.GetLength(1) || row < 0 || row == labirint.GetLength(0))
            {
                return;
            }

            if (labirint[row, col] == 'f')
            {
                path[pathCurrentIndex++] = direction;
                PrintPath();
            }

            if (labirint[row, col] != ' ')
            {
                return;
            }

            labirint[row, col] = 'x';
            path[pathCurrentIndex++] = direction;

            // Move right
            FindPathLabirint(row, col + 1, 'R');
            // Move up
            FindPathLabirint(row - 1, col, 'U');
            // Move left
            FindPathLabirint(row, col - 1, 'L');
            //Move down
            FindPathLabirint(row + 1, col, 'D');

            labirint[row, col] = ' ';
            pathCurrentIndex--;
        }

        static void PrintPath()
        {
            for (int a = 0; a < pathCurrentIndex; a++)
            {
                Console.Write(path[a]);
            }

            Console.WriteLine();
        }
    }
}
