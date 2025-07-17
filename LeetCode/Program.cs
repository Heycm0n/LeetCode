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
    public int MinSum = int.MaxValue;
    public int Recursive(string s1, string s2, int Sum) 
    {        
        FindSimilarSubString(s1, s2, Sum);
        string s2_copy = s2;

        for (int i = 0; i < s2.Length; i++)
        {
            s2_copy = s2.Remove(i, 1);
            Recursive(s1, s2_copy, Sum + (int)s2[i]);
        }

        return Sum;
    }
    public void FindSimilarSubString(string s1, string s2, int Sum) 
    {
        int s_index = 0;
        int complete_flag = 0;
        for (int i = 0; i < s1.Length; i++) 
        {
            if ((complete_flag!= 1)&&(s2.Length > 0)&&(s1[i] == s2[s_index]))
            {
                s_index++;
                if (s_index == s2.Length) 
                {
                    complete_flag = 1;
                }              
            }
            else 
            {
                Sum += (int)s1[i];
            }
        }

        if((complete_flag == 1)&&(Sum < MinSum))
            MinSum = Sum;
        return;
    }
    public int MinimumDeleteSum(string s1, string s2)
    {
        int sum = 0;
        if (String.Compare(s1, s2) == 0) { return sum; }

        if (s2.Length > s1.Length) //S1 должна быть более длинной строкой
        {
            string tmp = s1;
            s1 = s2;
            s2 = tmp;
        }

        for (int i = 0; i < s1.Length; i++) //”бираем все символы которые не встречаютс€ в обеих строках
        {
            if (!s2.Contains(s1[i])) 
            {
                sum += (int)s1[i];
                s1 = s1.Remove(i, 1);
                i--;
            }               
        }

        if (s1.Length == 0) 
        {
            for(int i =0; i< s2.Length; i++)
                sum += (int)s2[i];
            return sum;
        } 

        if (s2.Length > s1.Length) //ѕосле удалени€ все еще S1 должна быть более длинной строкой
        {
            string tmp = s1;
            s1 = s2;
            s2 = tmp;
        }

        Recursive(s1, s2, sum);
        return MinSum;
    }
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        string s1 = "acacabcaabac";
        string s2 = "accabaccccabaca";
        //int[] nums = { 57, 44, 92, 28, 66, 60, 37, 33, 52, 38, 29, 76, 8, 75, 22 };
        
        int answ = solution.MinimumDeleteSum(s1, s2);
        Console.WriteLine(answ);

    }
}

