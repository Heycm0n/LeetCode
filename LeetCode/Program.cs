using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Primitives;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Globalization;

public class Solution
{
    public bool IsOneBitCharacter(int[] bits)
    {
        //если две единицы встречаются в тексте то это точно 11, то есть удалив все 11 из текста мы гарантируем что в тексте остались только 10 и 0
        //если после этого в тексте встречаются 2 и более подряд 0 то это значит что это 10 + 0, значит можно заменить все повторяющиеся 0 одним. (кроме случая когда они в самом начале строки)
        //потом в строке должно остаться только 10

        //Либо просто находим следующй за этим ноль. Если он следующий то это точно один бит. Если он через четное количество 1 то тоже 0, нечетное то 10.
        int counter = 0;
        for (int i = bits.Length - 2; i >= 0; i--) 
        {
            if (bits[i] == 0)
            {
                break;
            }
            else 
            {
                counter++;
            }
        }

        if (counter % 2 != 0) 
            return false;
        else 
            return true;
        
    }

    static void Main(string[] args)
    {
        Solution solution = new Solution();

        //string[] words = { "a", "banana", "app", "appl", "ap", "apply", "apple" };
        int[] nums = { 1, 1, 1, 0 };
        bool answ = solution.IsOneBitCharacter(nums);
        Console.WriteLine(answ);

    }
}

