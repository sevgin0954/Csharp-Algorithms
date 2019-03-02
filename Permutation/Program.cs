using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "ABC";
        char[] charArry = str.ToCharArray();
        Permute(charArry, 0);
    }

    static void Permute(char[] arr, int i)
    {
        if (i == arr.Length - 1)
        {
            Console.WriteLine(arr);
            return;
        }

        for (int a = i; a < arr.Length; a++)
        {
            Swap(ref arr[i], ref arr[a]);
            Permute(arr, i + 1);
            Swap(ref arr[i], ref arr[a]);
        }
    }

    static void Swap(ref char a, ref char b)
    {
        char tmp = a;
        a = b;
        b = tmp;
    }
}