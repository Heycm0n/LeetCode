using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Solution
{
    public List<string> _Solutions;
    public void DivideSubStrings(string str, int char_del_num, string s, int k) 
    {
        if (CountSubStr(str, s) == k)
        {
            //return str;
            if(!_Solutions.Contains(str)) _Solutions.Add(str);
        }
        else 
        {        
            string substr = str.Remove(char_del_num, 1); //Получаем новую подстроку. Проверяем ее.
            if (substr.Length < 2) return;
            
            for (int i = 0; i < substr.Length; i++) 
            {
                DivideSubStrings(substr, i, s, k);  
            }         
        }
        return;
    }
    public int CountSubStr(string substr, string s) 
    {
        int substr_char_num = 0;
        int Count = 0;
        for (int i = 0; i < s.Length; i++) 
        {
            if (s[i] == substr[substr_char_num]) 
                if (++substr_char_num >= substr.Length) 
                {
                    substr_char_num = 0;
                    Count++;
                } 
        }
        return Count;
    }
    public string LongestSubsequenceRepeatedK(string s, int k)
    {
        _Solutions = new List<string>();
        Dictionary<char, int> charlist = new Dictionary<char, int>();

        //Удаляем лишние буквы.
        for (int i = 0; i < s.Length; i++)
        {
            charlist.TryGetValue(s[i], out int num);
            if (num == 0)
                charlist.Add(s[i], 1);
            else
                charlist[s[i]] += 1;
        }


        foreach (char c in charlist.Keys)
        {
            if(charlist[c] < k)
                for (int i = 0; i < s.Length; i++) 
                {
                    if (s[i] == c) 
                        s = s.Remove(i, 1);
                }
        }

        if (s.Length < k) return string.Empty;
        //Основной цикл следит за размером последовательности

        int substr_len = s.Length - (k - 1);
        string substr = new string("");
        substr = s.Substring(0, substr_len);    //Смотрим самую большую последовательность
        for (int i = 0; i < substr.Length; i++)
        {
            DivideSubStrings(substr, i, s, k);
        }

        if (_Solutions.Count == 0)
            return string.Empty;
        else 
        {
            string true_solution = string.Empty;
            for (int i = 0; i < _Solutions.Count; i++) 
            {
                if (_Solutions[i].Length > true_solution.Length) true_solution = _Solutions[i];
                else if ((_Solutions[i].Length == true_solution.Length)&&(string.Compare(_Solutions[i], true_solution) > 0)) 
                    true_solution = _Solutions[i];
            }
            return true_solution;
        }
    }

    static void Main(string[] args)
    {
        Solution solution = new Solution();

        string str = "letsleetcode";
        int k = 2;

        Console.WriteLine(solution.LongestSubsequenceRepeatedK(str, k));
    }
}

