using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Solution
{
    public int FindLHS(int[] nums)
    {
        int Max_len = 0;
        
        Dictionary <int, int> NumCount = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) 
        {
            if (NumCount.ContainsKey(nums[i])) { NumCount[nums[i]]++; }
                else NumCount.Add(nums[i], 1);
        }

        foreach(int i in NumCount.Keys)
        {
            if ((NumCount.ContainsKey(i+1))&&(NumCount[i] + NumCount[i + 1]) > Max_len) Max_len = (NumCount[i] + NumCount[i + 1]);
        }

        return Max_len;
    }
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] x = {1,2,3,2,3,4,4};

        Console.WriteLine(solution.FindLHS(x));
    }
}

