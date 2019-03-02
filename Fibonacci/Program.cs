using System;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFibonacci(n));
        }

        private static int CalculateFibonacci(int n)
        {
            int firstNum = 0;
            int secondNum = 1;

            for (int a = 2; a < n; a++)
            {
                int temp = secondNum;
                secondNum = firstNum + secondNum;
                firstNum = temp;
            }

            return firstNum + secondNum;
        }
    }
}
