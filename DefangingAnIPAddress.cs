using System.Text;

namespace csharp_algorithms.algorithms;

public class DefangingAnIPAddress
{
    /*public static void Main(string[] args)
    {
        var address = "255.100.50.0";
        var ans = DefangIPaddr(address);
        Console.WriteLine(ans);
    }*/

    private static string DefangIPaddr(string address) => address.Replace(".", "[.]");
    
    private static string DefangIPaddr1(string address)
    {
        StringBuilder sb = new();
        foreach (var c in address)
        {
            if (c == '.') sb.Append("[.]");
            else sb.Append(c);
        }
        return sb.ToString();
    }
}