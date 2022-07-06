using Microsoft.VisualBasic;

namespace csharp_algorithms.algorithms;

public class FibonacciNumber
{
    /*public static void Main(string[] args)
    {
        var ans = Fib(4);
        Console.WriteLine(ans);
    }*/

    private static int Fib(int num)
    {
        if(num == 0) return 0;
        var arr = new int[num + 1];
        arr[0] = 0;
        arr[1] = 1;
        if (num <= 1) return arr[num];
        for (int i = 2; i < arr.Length; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }
        return arr[num];
    }

    public int FibRecursive(int num)
    {
        if(num == 0)
            return 0;
        if(num == 1)
            return 1;
        return Fib(num - 1) + Fib(num - 2);
    }
}