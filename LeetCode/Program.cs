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
    public int MinimumDeleteSum(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;

        // Создаем таблицу DP размером (m+1) x (n+1)
        int[,] dp = new int[m + 1, n + 1];

        // Заполняем первую строку и первый столбец нулями (базовый случай)
        for (int i = 1; i <= m; i++)
        {
            dp[i, 0] = dp[i - 1, 0] + s1[i - 1];
        }
        for (int j = 1; j <= n; j++)
        {
            dp[0, j] = dp[0, j - 1] + s2[j - 1];
        }

        // Заполняем таблицу DP
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (s1[i - 1] == s2[j - 1])
                {
                    // Если символы совпадают, добавляем их ASCII код к предыдущему результату
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else
                {
                    // Если символы не совпадают, выбираем минимальную сумму удалений
                    dp[i, j] = Math.Min(
                        dp[i - 1, j] + s1[i - 1],  // Удаляем символ из s1
                        dp[i, j - 1] + s2[j - 1]   // Удаляем символ из s2
                    );
                }
            }
        }

        // Результат находится в dp[m, n]
        return dp[m, n];
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

