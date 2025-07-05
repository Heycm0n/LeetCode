using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Primitives;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Solution
{
    public int max_sub = 0;
    void func(int i, int j, int[] nums1, int[] nums2, int row) 
    {     
        if (((i-row) < 0) || ((j - row) < 0)) return; //Выходим если доходим до конца
        if (nums1[i - row] == nums2[j - row])
        {
            row++;
            if (row > max_sub) max_sub = row;
            func(i, j, nums1, nums2, row);
        }
        return;
    }
    public int FindLength(int[] nums1, int[] nums2)
    {
        for (int i = nums1.Length - 1; i >= 0; i--)
            for (int j = nums2.Length - 1; j >= 0; j--)
            {
                func(i, j, nums1, nums2, 0);
                if (max_sub > i) break;
            }
           
        return max_sub;
    }
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        //string[] words = { "a", "banana", "app", "appl", "ap", "apply", "apple" };
        int[] nums1 = { 1, 1, 0, 0, 1 };
        int[] nums2 = { 1, 1, 0, 0, 0 };
        int answ = solution.FindLength(nums1, nums2);
        Console.WriteLine(answ);

    }
}

