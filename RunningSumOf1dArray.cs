namespace csharp_algorithms.algorithms;

public class RunningSumOf1dArray
{
    /*public static void Main(string[] args)
    {
        var nums = new int[] { 1, 2, 3, 4 };
        var ans = RunningSum(nums);
        Console.WriteLine(String.Join(",", ans));
    }*/

    private static int[] RunningSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }
        return nums;
    }
}