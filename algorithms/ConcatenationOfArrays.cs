namespace csharp_algorithms.algorithms;

public class ConcatenationOfArrays
{
    /*public static void Main(string[] args)
    {
        var nums = new int[] { 1, 2, 3 };
        var ans = Concatenate(nums);
        Console.WriteLine(String.Join(", ", ans));
    }*/

    private static int[] Concatenate(int[] nums)
    {
        var res = new int[nums.Length * 2];
        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = nums[i];
            res[i + nums.Length] = nums[i];
        }
        return res;
    }
    
    private static int[] Concatenate1(int[] nums)
    {
        var res = nums.Concat(nums);
        return res.ToArray();
    }
}