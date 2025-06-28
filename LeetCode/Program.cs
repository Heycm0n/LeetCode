using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int maxSum = nums[0], currentSum = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }
        return maxSum;
    }
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] nums = {-2, 1, -3, 4, -1, 2, 1, -5, 4 };

        Console.WriteLine(solution.MaxSubArray(nums));
    }
}

