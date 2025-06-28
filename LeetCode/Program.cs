using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        int dig = 0;
        while (x / (int)Math.Pow(10, dig + 1) > 0)
        {
            dig++;
        }

        while (dig > 0)
        {
            int a = x / (int)Math.Pow(10, dig);
            if ((x / (int)Math.Pow(10, dig)) != (x % 10)) return false;
            x = (x % (int)Math.Pow(10, dig)) / 10;
            dig -= 2;
        }

        return true;
    }
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        int x = 121;

        Console.WriteLine(solution.IsPalindrome(x));
    }
}

