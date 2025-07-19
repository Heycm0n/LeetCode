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
    public List<int> Blacklist;
    public List<int> AltValues;
    public int border;
    public int N;
    public Solution(int n, int[] blacklist)
    {
        Blacklist = blacklist.ToList();
        Blacklist.Sort();
        N = n;
        AltValues = new List<int>();
        border = N - Blacklist.Count;
        for (int i = border; i < N; i++) 
        {
            if (!Blacklist.Contains(i))
            {
                AltValues.Add(i);
            }
        }
    }

    public int Pick()
    {
        Random rnd = new Random();
        int res = rnd.Next(0, border);

        for (int i = 0; i < Blacklist.Count; i++) 
        {
            if (res == Blacklist[i]) return AltValues[i];
        }
        /*
        if (Blacklist.Contains(res)) 
        {
            res = rnd.Next(0, AltValues.Count);
            return AltValues[res];
        } 
         */
        return res;
    }
}

public class main
{
    static void Main(string[] args)
    {
        //string s1 = "acacabcaabac";
        //string s2 = "accabaccccabaca";
        //int[] nums = { 57, 44, 92, 28, 66, 60, 37, 33, 52, 38, 29, 76, 8, 75, 22 };
        //int[] a = new int[5] {1,2,3,4,51};

        Solution solution = new Solution(3, new int[] { 2, 0 });
   
        for(int i = 0; i < 30; i++) 
        {
            int param_1 = solution.Pick(); 
            Console.WriteLine(param_1);
        }
    }
}

