using System;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Reverse(n));
    }

    public static int Reverse(int x)
    {
        char[] arr = x.ToString().ToCharArray();

        int startIndex = 0;
        int endIndex = arr.Length - 1;

        if (arr[0] == '-')
        {
            startIndex = 1;
        }

        while (startIndex < endIndex)
        {
            char temp = arr[startIndex];
            arr[startIndex] = arr[endIndex];
            arr[endIndex] = temp;

            startIndex++;
            endIndex--;
        }

        string reversedNumAsString = string.Join("", arr);

        int result = int.Parse(reversedNumAsString);

        return result;
    }
}