namespace csharp_algorithms.algorithms;

public class FinalValueAfterOperations
{
    /*public static void Main(string[] args)
    {
        var ops = new string[] { "--X", "X++", "X++" };
        var ans = FinalValueAfterOps(ops);
        Console.WriteLine(ans);
    }*/

    private static int FinalValueAfterOps(string[] operations)
    {
        var x = 0;
        foreach (var op in operations)
        {
            x = op.Contains("--") ? x - 1 : x + 1;
        }
        return x;
    }
}