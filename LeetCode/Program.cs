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
        //���� ��� ������� ����������� � ������ �� ��� ����� 11, �� ���� ������ ��� 11 �� ������ �� ����������� ��� � ������ �������� ������ 10 � 0
        //���� ����� ����� � ������ ����������� 2 � ����� ������ 0 �� ��� ������ ��� ��� 10 + 0, ������ ����� �������� ��� ������������� 0 �����. (����� ������ ����� ��� � ����� ������ ������)
        //����� � ������ ������ �������� ������ 10

        //���� ������ ������� �������� �� ���� ����. ���� �� ��������� �� ��� ����� ���� ���. ���� �� ����� ������ ���������� 1 �� ���� 0, �������� �� 10.
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

