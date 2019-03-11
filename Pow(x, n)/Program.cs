using System;
using System.Collections.Generic;

namespace Pow_x__n_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(MyPow(34.00515, -3));
        }

        public static double MyPow(double x, int n)
        {
            return PowerRecursion(x, n, new Dictionary<int, double>());
        }

        public static double PowerRecursion(double x, int n, Dictionary<int, double> dictionary)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1 || n == -1)
            {
                return x;
            }
            if (dictionary.ContainsKey(n) == true)
            {
                return dictionary[n];
            }

            double result = 0;

            if (n % 2 == 0)
            {
                result = PowerRecursion(x, n / 2, dictionary) * PowerRecursion(x, n / 2, dictionary);
            }
            else
            {
                result = x * PowerRecursion(x, n / 2, dictionary) * PowerRecursion(x, n / 2, dictionary);
            }

            if (n < 0)
            {
                result = 1 / result;
            }

            dictionary[n] = result;

            return result;
        }
    }
}
