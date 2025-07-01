using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Solution
{
    public int TupleSameProduct(int[] nums)
    {
        int TupleCount = 0; 
        Dictionary<int, int> res_tbl = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length - 1; i++)
            for (int j = i+1; j < nums.Length; j++) 
            {
                int res = nums[i] * nums[j];
                if (res_tbl.ContainsKey(res)) 
                {
                    TupleCount += (++res_tbl[res] - 1) * 8;
                } 
                else 
                    res_tbl.Add(res, 1);
            }

        return TupleCount;
    }
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        int[] x = { 8, 448, 264, 525, 435, 486, 378, 308, 144, 75, 196, 110, 231, 120, 39, 288, 50, 616, 140, 261, 272, 783, 225, 552, 598, 30, 128, 570, 322, 77, 340, 19, 72, 224, 294, 390, 276, 87, 238, 180, 80, 33, 68, 210, 725, 243, 696, 198, 208, 46, 21, 58, 360, 170, 190, 510, 375, 551, 348, 396, 377, 69, 84, 300, 572, 468, 160, 24, 34, 667, 29, 64, 253, 115, 690, 100, 870, 754, 102, 1, 11, 312, 609, 161, 493, 450, 342, 133, 588, 48, 152, 10, 42, 273, 440, 728, 65, 98, 5, 23, 250, 242, 38, 182, 26, 648, 99, 357, 400, 275, 187, 483, 414, 323, 408, 105, 230, 520, 750, 4, 500, 32, 286, 418, 189, 638, 528, 234, 315, 96, 352, 812, 232, 40, 3, 130, 184, 17, 15, 324, 240, 392, 7, 174, 270, 416, 513, 25, 203, 221, 399, 475, 9, 54, 476, 442, 406, 840, 12, 504, 114, 675, 624, 621, 56, 405, 125, 119, 136, 506, 702, 364, 70, 60, 228, 20, 85, 575, 135, 117, 78, 171, 156, 55, 299, 462, 116, 780, 52, 432, 165, 88, 325, 338, 391, 546, 522, 209, 176, 108 };        Console.WriteLine(solution.TupleSameProduct(x));
    }
}

