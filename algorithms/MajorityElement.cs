namespace csharp_algorithms.algorithms;

public class MajorityElement
{
    /*public static void Main(string[] args)
    {
        var nums = new int[] { 6, 5, 5 };
        var ans = MajorityElementFunc(nums);
        Console.WriteLine(ans);
    }*/

    private static int MajorityElementFunc(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        int majorElement = - 1;
        int majorValue = nums.Length / 2;
        foreach (var num in nums)
        {
            dict[num] = dict.ContainsKey(num) ? dict[num] + 1 : 1;

            if (dict.ContainsKey(majorElement))
            {
                if (dict[majorElement] < dict[num])
                {
                    majorElement = num;
                }
            }
            else
            {
                majorElement = num;
            }
        }
        return majorElement;
    }
}