using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using Microsoft.Extensions.Primitives;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Runtime.Intrinsics;

public class Solution
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        if (k <= 1)
            return 0;

        int product = 1;
        int count = 0;
        int left = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            product *= nums[right];

            while (product >= k)
            {
                product /= nums[left];
                left++;
            }

            count += right - left + 1;
        }

        return count;
    }

    static void Main(string[] args)
    {
        Solution solution = new Solution();

        //string[] words = { "a", "banana", "app", "appl", "ap", "apply", "apple" };
        int[] nums = { 57, 44, 92, 28, 66, 60, 37, 33, 52, 38, 29, 76, 8, 75, 22 };
        
        int answ = solution.NumSubarrayProductLessThanK(nums, 18);
        Console.WriteLine(answ);

    }
}

