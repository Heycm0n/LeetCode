using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Primitives;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Solution
{
    public bool SearchForSubWords(string str, List<string> words) 
    {
        words.Remove(str);
        if (str.Length > 1)
        {
            //Надо как то удалять просмотренные уже элементы чтоб они не лежали в списке и хламили. Возможно стоит сформировать какой нибудь словарь и отмечать там уже пройденные слова
            str = str.Substring(0, str.Length-1);
            if (words.Contains(str))
            {
                return SearchForSubWords(str, words);
            }
            else 
            {
                return false;
            }
        }
        else return true;
    }
    public string LongestWord(string[] words)
    {
        
        Array.Sort(words, (a, b) => b.Length.CompareTo(a.Length));
        List<string> word_list = words.ToList();      
        string Max_word = string.Empty;

        foreach (string word in words) 
        {
            if (word.Length < Max_word.Length) return Max_word;

            if (SearchForSubWords(word, word_list) == true) 
            {          
                if(Max_word == string.Empty) 
                    Max_word = word;
                else
                    if (String.Compare(word, Max_word) < 0) 
                        Max_word = word;
            }
        }

        return Max_word;
    }
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        string[] words = { "a", "banana", "app", "appl", "ap", "apply", "apple" };
        string answ = solution.LongestWord(words);
        Console.WriteLine(answ);

    }
}

