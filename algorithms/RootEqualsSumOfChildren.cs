namespace csharp_algorithms.algorithms;

public class RootEqualsSumOfChildren
{
    /*public static void Main(string[] args)
    {
        TreeNode left = new(4);
        TreeNode right = new(6);
        TreeNode root = new(10, left, right);
        var ans = CheckTree(root);
        Console.WriteLine(ans);
    }*/

    private static bool CheckTree(TreeNode root)
    {
        return root.left.val + root.right.val == root.val;
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}