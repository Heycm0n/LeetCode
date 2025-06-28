using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> chars = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(') chars.Push(')');
            else if (c == '[') chars.Push(']');
            else if (c == '{') chars.Push('}');
            else if ((chars.Count == 0) || (chars.Pop() != c)) return false;
        }
        if (chars.Count == 0) return true;
        else return false;
    }
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        string str = "{}()[]{}";

        Console.WriteLine(solution.IsValid(str));
    }
}

