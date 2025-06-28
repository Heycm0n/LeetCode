using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> result = new HashSet<int>();
        foreach (int num in nums)
        {
            if (result.Contains(num)) return true;
            else result.Add(num);
        }
        return false;
    }
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

        Console.WriteLine(solution.ContainsDuplicate(nums));
    }
}

