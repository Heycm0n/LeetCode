using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using Microsoft.Extensions.Internal;
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
    public string ToLowerCase(string s)
    {
        char[] s_tmp = s.ToCharArray();
        for (int i = 0; i < s.Length; i++) 
        {
            if ((s_tmp[i]>64)&&(s_tmp[i] < 91))
            {
                s_tmp[i] = (char)(s[i] + 32);
            }
           
        }
  
        return (new string(s_tmp));
    }
    
    static void Main(string[] args)
    {
        string s1 = "Hello";
        //string s2 = "accabaccccabaca";
        //int[] nums = { 57, 44, 92, 28, 66, 60, 37, 33, 52, 38, 29, 76, 8, 75, 22 };
        //int[] a = new int[5] {1,2,3,4,51};
        Solution solution = new Solution();
        s1 = solution.ToLowerCase(s1);
        Console.WriteLine(s1);

    }
}

public class main
{
}


