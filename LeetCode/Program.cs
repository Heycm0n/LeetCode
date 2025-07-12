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
    public int MaxProfit(int[] prices, int fee)
    {
        int cash = 0;           // Максимальная прибыль без акции
        int hold = -prices[0];  // Максимальная прибыль с акцией (купили в первый день)

        for (int i = 1; i < prices.Length; i++)
        {
            cash = Math.Max(cash, hold + prices[i] - fee); // Продаем или ничего не делаем
            hold = Math.Max(hold, cash - prices[i]);        // Покупаем или ничего не делаем
        }

        return cash; // В конце выгоднее не иметь акций
    }

    static void Main(string[] args)
    {
        Solution solution = new Solution();

        //string[] words = { "a", "banana", "app", "appl", "ap", "apply", "apple" };
        int[] prices = { 2, 1, 4, 4, 2, 3, 2, 5, 1, 2 };
        
        int answ = solution.MaxProfit(prices, 1);
        Console.WriteLine(answ);

    }
}

