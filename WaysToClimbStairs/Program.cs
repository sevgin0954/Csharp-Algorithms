using System;

namespace WaysToClimbStairs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(NumWays(4));
        }

        static int NumWays(int startirsCount)
        {
            if (startirsCount == 0 || startirsCount == 1)
            {
                return 1;
            }

            return NumWays(startirsCount - 1) + NumWays(startirsCount - 2);
        }
    }
}
