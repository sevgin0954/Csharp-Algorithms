using System;

namespace Hanoi
{
    class Program
    {
        static int count = 0;

        static void Main()
        {
            Hanoi(3, 'A', 'B', 'C');

            Console.WriteLine(count);
        }

        static void Hanoi(int n, char from, char middle, char destination)
        {
            if (n == 1)
            {
                Console.WriteLine($"Moving disk {n} from {from} to {destination}");
                count++;
                return;
            }

            Hanoi(n - 1, from, destination, middle);
            Console.WriteLine($"Moving disk {n} from {from} to {destination}");
            count++;
            Hanoi(n - 1, middle, from, destination);
        }
    }
}
