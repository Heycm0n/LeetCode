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
        int answ = 0;

        int product = 1;
        int right = 0;
        int left = 0;

        while (right < nums.Length) 
        {          
            product *= nums[right];
            if (product >= k) 
            {
                if (left == right)
                {
                    product /= nums[left];
                    left++;
                    right++;
                }
                else
                {                
                    product /= nums[left];
                    product /= nums[right];
                    left++;
                }                  
            }
            else
            {
                right++;
                answ += right - left;
            }
            
        }

        return answ;
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

